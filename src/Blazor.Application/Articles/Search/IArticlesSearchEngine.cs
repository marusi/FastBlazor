using System.Threading.Tasks;
using Blazor.Application.Articles.Search.Dto;
using Blazor.Domain.Models.Articles;

namespace Blazor.Application.Articles.Search
{
	public interface IArticlesSearchEngine
	{
		Task<SearchResultDto<ArticleSearchDto>> SearchAsync(string query, int pageNumber, int resultsPerPage);
	}
}
