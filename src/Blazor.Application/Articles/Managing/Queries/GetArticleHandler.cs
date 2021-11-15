using System.Threading;
using System.Threading.Tasks;
using Blazor.Application.Articles.Managing.Dto;
using Blazor.Application.Common;
using Blazor.Domain.Models.Articles;
using CoreWiki.Application.Articles.Managing;
using CoreWiki.Application.Articles.Managing.Queries;
using MediatR;

namespace Blazor.Application.Articles.Managing.Queries
{ 
	class GetArticleHandler : IRequestHandler<GetIsTopicAvailableQuery, bool>,
		IRequestHandler<GetArticleQuery, ArticleManageDto>
	{
		private readonly IArticleManagementService _service;

		public GetArticleHandler(IArticleManagementService service)
		{
			_service = service;
		}

		public Task<bool> Handle(GetIsTopicAvailableQuery request, CancellationToken cancellationToken)
		{
			var article = new Article { Topic = request.Topic };
			return _service.IsTopicAvailable(article.Slug, request.ArticleId);
		}

		public Task<ArticleManageDto> Handle(GetArticleQuery request, CancellationToken cancellationToken)
		{
			return _service.GetArticleBySlug(request.Slug);
		}
	}
}
