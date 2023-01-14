using EntityLayer.Concrete;

namespace OlaTvUI.Models
{
	public class ProfileVideoWatchingModel
	{
		public ProfileVideoWatching ProfileVideoWatching { get; set; }
		public IEnumerable<Profile> Profiles { get; set; }
		public IEnumerable<Video> Videos { get; set; }
	}
}
