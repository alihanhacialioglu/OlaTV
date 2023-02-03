using EntityLayer.Concrete;

namespace OlaTvUI.Models
{
	public class MainModel
	{
		public IEnumerable<Video> Videos { get; set; }
		public IEnumerable<GenreContent> GenreContents { get; set; }
	}
}
