using AutoMapper;
using Blazor.Application.Articles.Search.Dto;
using Blazor.Domain.Models.Articles;

namespace CoreWiki.Application.Articles.Search
{
	public class SearchArticleProfile: Profile
	{
		public SearchArticleProfile()
		{
			CreateMap<Article, ArticleSearchDto>();
		}
	}
}
