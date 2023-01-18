using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPacketService
    {
        void Add(Packet packet);
        void Remove(Packet packet);
        void Update(Packet packet);
        List<Packet> GetAll();
        Packet GetById(int id);
        Packet GetByCount(int count);
        Packet GetByName(string name);
        Packet GetByPrice(float price);
        Packet GetByQuality(string quality);
        Packet GetByExplanation(string explanation);
    }
}
