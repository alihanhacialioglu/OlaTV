using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PacketManager : IPacketService
    {
        IPacketDal _packetDal;
        public PacketManager(IPacketDal packetDal)
        {
            _packetDal = packetDal;
        }

        public void Add(Packet packet)
        {
            _packetDal.Add(packet);
        }

        public List<Packet> GetAll()
        {
           return _packetDal.GetAll();
        }

        public Packet GetByCount(int count)
        {
            return _packetDal.Get(p=>p.ViewCount==count);
        }

        public Packet GetByExplanation(string explanation)
        {
            return _packetDal.Get(p => p.PacketExplanation == explanation);
        }

        public Packet GetById(int id)
        {
            return _packetDal.Get(p => p.PacketId == id);
        }

        public Packet GetByName(string name)
        {
            return _packetDal.Get(p => p.PacketName == name);
        }

        public Packet GetByPrice(float price)
        {
            return _packetDal.Get(p => p.PacketPrice == price);
        }

        public Packet GetByQuality(string quality)
        {
            return _packetDal.Get(p => p.PacketContentQuality == quality);
        }

        public void Remove(Packet packet)
        {
            _packetDal.Delete(packet);
        }

        public void Update(Packet packet)
        {
            _packetDal.Update(packet);
        }
    }
}
