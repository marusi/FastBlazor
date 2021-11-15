using MediatR;

namespace Blazor.Application.Articles.Reading.Queries
{
	public class GetIsTopicAvailableQuery : IRequest<bool>
	{
		public string Slug { get; set; }
		public int ArticleId { get; set; }
	}
}
