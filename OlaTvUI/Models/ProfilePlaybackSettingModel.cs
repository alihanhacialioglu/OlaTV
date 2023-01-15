using EntityLayer.Concrete;

namespace OlaTvUI.Models
{
	public class ProfilePlaybackSettingModel
	{
		public ProfilePlaybackSetting ProfilePlaybackSetting { get; set; }
		public IEnumerable<PlaybackSetting> PlaybackSettings { get; set; }
		public IEnumerable<Profile> Profiles { get; set; }
	}
}
