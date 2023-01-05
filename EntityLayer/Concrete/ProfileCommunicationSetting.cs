using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProfileCommunicationSetting
    {
        [Key]
        public int ProfileCommunicationSettingId { get; set; }
        public bool ProfileCommunicationSettingSelection { get; set; }

        //Relation with Profile
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }

        //Relation with CommunicationSetting
        public int CommunicationSettingId { get; set; }
        public virtual CommunicationSetting CommunicationSetting { get; set; }

		public bool IsDelete { get; set; }
	}
}
