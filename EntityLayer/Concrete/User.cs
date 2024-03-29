﻿using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User : BaseEntity
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(30)]
        public string UserName { get; set; }

        [StringLength(30)]
        public string Password { get; set; }

        [StringLength(50)]
        public string EmailAddress { get; set; }

        [StringLength(11)]
        public string PhoneNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public int AccessPin { get; set; }
        
        //Relation with Packet
        public int PacketId { get; set; }
        public virtual Packet Packet { get; set; }

		public bool IsDelete { get; set; }

		//Relation with CreditCard
		public virtual ICollection<CreditCard> CreditCards { get; set; }

        //Relation with Profile
        public virtual ICollection<Profile> Profiles { get; set; }

    }
}
