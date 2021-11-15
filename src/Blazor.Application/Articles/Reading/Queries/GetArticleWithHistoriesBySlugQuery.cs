using Blazor.Application.Articles.Reading.Dto;
using MediatR;

namespace Blazor.Application.Articles.Reading.Queries
{
	public class GetArticleWithHistoriesBySlugQuery: IRequest<ArticleReadingDto>
	{
		public string Slug { get; }

		public GetArticleWithHistoriesBySlugQuery(string slug)
		{
			Slug = slug;
		}
	}
}
