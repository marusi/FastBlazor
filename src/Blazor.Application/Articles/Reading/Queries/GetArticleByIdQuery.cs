using Blazor.Application.Articles.Reading.Dto;
using MediatR;

namespace Blazor.Application.Articles.Reading.Queries
{
	public class GetArticleByIdQuery : IRequest<ArticleReadingDto>
	{
		public int Id { get; }
		public GetArticleByIdQuery(int id) => Id = id;
	}
}
