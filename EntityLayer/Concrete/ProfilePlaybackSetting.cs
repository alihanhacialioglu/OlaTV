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
        public bool PlaybackPlaybackSelection { get; set; }

        //Relation with PlaybackSetting
        public int PlaybackSettingId { get; set; }
        public virtual PlaybackSetting PlaybackSetting { get; set; }

        //Relation with Profile
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }

    }
}
