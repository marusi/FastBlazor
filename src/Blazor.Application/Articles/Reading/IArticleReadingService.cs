using System.Collections.Generic;
using System.Threading.Tasks;
using Blazor.Application.Articles.Reading.Dto;

namespace Blazor.Application.Articles.Reading
{
	public interface IArticleReadingService
	{
		Task<ArticleReadingDto> GetArticleBySlug(string articleSlug);
		Task<bool> IsTopicAvailable(string articleSlug, int articleId);
		Task<SlugHistoryDto> GetSlugHistoryWithArticle(string slug);

		Task CreateComment(CreateCommentDto commentDto);

		Task<ArticleReadingDto> GetArticleById(int articleId);
		Task<ArticleReadingDto> GetArticleWithHistoriesBySlug(string articleSlug);

		Task<List<ArticleReadingDto>> GetLatestArticles(int numOfArticlesToGet);
		Task IncrementViewCount(string slug);
	}
}
