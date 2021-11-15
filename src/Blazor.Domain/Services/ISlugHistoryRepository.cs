using System;
using System.Threading.Tasks;
using Blazor.Domain.Models.Articles;


namespace Blazor.Domain.Services
{
	public interface ISlugHistoryRepository : IDisposable
	{

		Task<SlugHistory> GetSlugHistoryWithArticle(string slug);

		Task AddToHistory(string oldSlug, Article article);

		Task DeleteAllHistoryOfArticle(int articleId);
	}
}
