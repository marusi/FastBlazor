using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CoreWiki.Application.Articles.Managing.Queries;
using MediatR;

namespace Blazor.Application.Articles.Managing.Queries
{

	public class GetArticlesToCreateFromArticleHandler : IRequestHandler<GetArticlesToCreateFromArticleQuery, (string,string[])>
	{
		private readonly IArticleManagementService _articleReadingService;

		public GetArticlesToCreateFromArticleHandler(IArticleManagementService articleReadingService)
		{
			_articleReadingService = articleReadingService;
		}

		public async Task<(string,string[])> Handle(GetArticlesToCreateFromArticleQuery request, CancellationToken cancellationToken)
		{
			var result = await _articleReadingService.GetArticlesToCreate(request.ArticleId);
			return (result.Item1, result.Item2.ToArray());
		}

	}
}
