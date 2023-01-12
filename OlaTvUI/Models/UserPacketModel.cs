using EntityLayer.Concrete;

namespace OlaTvUI.Models
{
    public class UserPacketModel
    {
        public User? UserModel { get; set; }
        public IEnumerable<Packet> PacketModel { get; set; }
    }
}
