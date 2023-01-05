using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Packet
    {
        [Key]
        public int PacketId { get; set; }

        [StringLength(20)]
        public string PacketName { get; set; }
        public int ViewCount { get; set; }
        public float PacketPrice { get; set; }

        [StringLength(20)]
        public string PacketContentQuality { get; set; }

        [StringLength(300)]
        public string PacketExplanation { get; set; }

		public bool IsDelete { get; set; }

		//Relation with User
		public virtual ICollection<User> User { get; set; }
    }
}
