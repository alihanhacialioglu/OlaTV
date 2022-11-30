using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PlaybackSetting
    {
        [Key]
        public int PlaybackSettingId { get; set; }

        [StringLength(20)]
        public string PlaybackName { get; set; }

        [StringLength(100)]
        public string PlaybackExplanation { get; set; }

        //Relation with ProfilePlaybackSetting
        public ICollection<ProfilePlaybackSetting> ProfilePlaybackSettings { get; set; }
    }
}
