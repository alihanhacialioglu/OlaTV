using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Profile
    {
        [Key]
        public int ProfileId { get; set; }

        [StringLength(20)]
        public string ProfileName { get; set; }

        public int ProfilePin { get; set; }
        public bool IsAnimationTv { get; set; }
        public bool IsMarketingApproval { get; set; }

        //Relation with User
        public int UserId { get; set; }
        public virtual User User { get; set; }

        //Relation with Language
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }

        //Relation with MaturityRating
        public int MaturityRatingId { get; set; }
        public virtual MaturityRating MaturityRating { get; set; }

        //Relation with SubtitleAppearance
        public int SubtitleAppearanceId { get; set; }
        public virtual SubtitleAppearance SubtitleAppearance { get; set; }

		public bool IsDelete { get; set; }

		//Relation with ProfileContent
		public virtual ICollection<ProfileContent> ProfileContents { get; set; }
        public virtual ICollection<ProfileVideoWatching> ProfileVideoWatchings { get; set; }
        public virtual ICollection<ProfileVideoRating> ProfileVideoRatings { get; set; }
        public virtual ICollection<ProfileCommunicationSetting> ProfileCommunicationSettings { get; set; }
        public virtual ICollection<ProfilePlaybackSetting> ProfilePlaybackSettings { get; set; }


    }
}
