using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Resources;
using Microsoft.AspNetCore.Mvc;

namespace OlaTvUI.Controllers
{
    public class PacketController : Controller
    {
        PacketManager packetManager = new PacketManager(new EfPacketDal());
        public IActionResult Packet_Index()
        {
            var packets = packetManager.GetAll();
            return View(packets);
        }

        [HttpGet]
        public IActionResult Packet_Add()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult Packet_Add(Packet packet)
        {
            PacketValidator validator= new PacketValidator();
            var result=validator.Validate(packet);
            if (result.IsValid)
            {
                packetManager.Add(packet);
                return RedirectToAction("Packet_Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
           
        }

        [HttpGet]
        public IActionResult Packet_Update(int id)
        {
            var packet=packetManager.GetById(id);
            return View(packet);
        }

        [HttpPost]
        public IActionResult Packet_Update(Packet packet)
        {
            PacketValidator validator = new PacketValidator();
            var result = validator.Validate(packet);
            if (result.IsValid)
            {
                packetManager.Update(packet);
                return RedirectToAction("Packet_Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }

        public IActionResult Packet_Delete(int id)
        {
            Packet packet=packetManager.GetById(id);
            packetManager.Remove(packet);
            return RedirectToAction("Packet_Index");
        }
        public IActionResult Packet_Activate(int id)
        {
            Packet packet=packetManager.GetById(id);
            packet.IsDelete = false;
            packetManager.Update(packet);
            return RedirectToAction("Packet_Index");
        }

        public IActionResult Packet_Deactivate(int id)
        {
            Packet packet=packetManager.GetById(id);
            packet.IsDelete = true;
            packetManager.Update(packet);
            return RedirectToAction("Packet_Index");
        }
    }
}
