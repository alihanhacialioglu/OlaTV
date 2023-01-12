using EntityLayer.Concrete;

namespace OlaTvUI.Models
{
    public class UserModel
    {
        public User User { get; set; }
        public IEnumerable<Packet> Packets { get; set; }
    }
}
