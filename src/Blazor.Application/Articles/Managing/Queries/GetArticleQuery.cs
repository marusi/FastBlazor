using Blazor.Application.Articles.Managing.Dto;
using MediatR;

namespace Blazor.Application.Articles.Managing.Queries
{
	public class GetArticleQuery: IRequest<ArticleManageDto>
	{
		public string Slug { get; }
		public GetArticleQuery(string slug) => Slug = slug;
	}
}
