using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Video
    {
        [Key]
        public int VideoId { get; set; }

        [StringLength(100)]
        public string VideoUrl { get; set; }
        public DateTime ReleaseDate { get; set; }
        public byte SeasonNo { get; set; }
        public byte EpisodeNo { get; set; }

        //Relation with Language
        public int LanguageId { get; set; }
        public Language language { get; set; }

        //Relation with VideoLanguage
        public ICollection<VideoLanguage> VideoLanguages { get; set; }

        //Relation with Category
        public int CategoryId { get; set; }
        public Category category { get; set; }

        //Relation with ProfileVideoWatching
        public ICollection<ProfileVideoWatching> ProfileVideoWatchings { get; set; }

        //Relation with ProfileVideoRating
        public ICollection<ProfileVideoRating> ProfileVideoRatings { get; set; }

        //Relation with Content
        public int ContentId { get; set; }
        public Content content { get; set; }
    }
}
