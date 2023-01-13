using EntityLayer.Concrete;

namespace OlaTvUI.Models
{
	public class ContentCastTitleModel
	{
		public ContentCastTitle ContentCastTitle { get; set; }
		public IEnumerable<Content> Contents { get; set; }
		public IEnumerable<CastTitle> CastTitles { get; set; }
	}
}
