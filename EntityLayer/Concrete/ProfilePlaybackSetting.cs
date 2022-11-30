using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProfilePlaybackSetting
    {
        [Key]
        public int ProfilePlaybackSettingId { get; set; }
        public bool PlaybackSelection { get; set; }

        //Relation with PlaybackSetting
        public int PlaybackSettingId { get; set; }
        public PlaybackSetting playbackSetting { get; set; }

        //Relation with Profile
        public int ProfileId { get; set; }
        public Profile profile { get; set; }

    }
}
