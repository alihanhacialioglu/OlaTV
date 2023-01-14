using EntityLayer.Concrete;

namespace OlaTvUI.Models
{
	public class ProfileVideoRatingModel
	{
		public ProfileVideoRating ProfileVideoRating { get; set; }
		public IEnumerable<Profile> Profiles { get; set; }
		public IEnumerable<Video> Videos { get; set; }
	}
}
