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
        public string PlaybackSettingName { get; set; }

        [StringLength(100)]
        public string PlaybackSettingExplanation { get; set; }
		public bool IsDelete { get; set; }

		//Relation with ProfilePlaybackSetting
		public virtual ICollection<ProfilePlaybackSetting> ProfilePlaybackSettings { get; set; }
    }
}
