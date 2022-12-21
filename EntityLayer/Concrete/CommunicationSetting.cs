﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CommunicationSetting
    {
        [Key]
        public int CommunicationSettingId { get; set; }

        [StringLength(30)]
        public string CommunicationSettingName { get; set; }

        [StringLength(100)]
        public string CommunicationSettingExplanation { get; set; }

        //Relation with ProfileCommuniicationSetting
        public ICollection<ProfileCommunicationSetting> ProfileCommunicationSettings { get; set; }

    }
}
