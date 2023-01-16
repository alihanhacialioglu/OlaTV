using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Language : BaseEntity
    {
        [Key]
        public int LanguageId { get; set; }

        [StringLength(20)]
        public string LanguageName { get; set; }
		public bool IsDelete { get; set; }

		//Relation with Profile
		public virtual ICollection<Profile> Profiles { get; set; }

        //Relation with Video
        public virtual ICollection<Video> Videos { get; set; }
        //Relation with VideoLanguage
        public virtual ICollection<VideoLanguage> VideoLanguages { get; set; }

    }
}
