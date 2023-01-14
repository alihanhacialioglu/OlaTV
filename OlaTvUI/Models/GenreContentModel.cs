using EntityLayer.Concrete;

namespace OlaTvUI.Models
{
	public class GenreContentModel
	{
		public GenreContent GenreContent{ get; set; }
		public IEnumerable<Genre>? Genres { get; set; }
		public IEnumerable<Content>? Contents { get; set; }
	}
}
