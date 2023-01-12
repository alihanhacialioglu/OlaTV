using EntityLayer.Concrete;

namespace OlaTvUI.Models
{
	public class ContentModel
	{
		public Content Content { get; set; }
		public IEnumerable<MaturityRating> MaturityRatings { get; set; }
	}
}
