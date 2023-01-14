using EntityLayer.Concrete;

namespace OlaTvUI.Models
{
	public class VideoLanguageModel
	{
		public VideoLanguage VideoLanguage { get; set; }
		public IEnumerable<Video> Videos { get; set; }
		public IEnumerable<Language> Languages { get; set; }
	}
}
