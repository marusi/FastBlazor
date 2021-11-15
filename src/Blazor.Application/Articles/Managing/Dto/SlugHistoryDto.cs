using Blazor.Application.Articles.Reading.Dto;
using NodaTime;

namespace Blazor.Application.Articles.Managing.Dto
{
	public class SlugHistoryDto
	{
		public int Id { get; set; }

		public virtual ArticleReadingDto Article { get; set; }

		public string OldSlug { get; set; }

		public Instant Added { get; set; }
		public int Version { get; set; }
		public string Content { get; set; }
		public string AuthorName { get; set; }
		public Instant Published { get; set; }
	}
}
