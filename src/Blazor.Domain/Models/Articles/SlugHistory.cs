using NodaTime;

namespace Blazor.Domain.Models.Articles
{
	public class SlugHistory {

		public int Id { get; set; }

		public virtual Article Article { get; set; }

		public string OldSlug { get; set; }

		public Instant Added { get; set; }

	}

}
