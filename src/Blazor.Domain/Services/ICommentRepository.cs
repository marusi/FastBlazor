using System;
using System.Threading.Tasks;
using Blazor.Domain.Models.Articles;


namespace Blazor.Domain.Services
{
	public interface ICommentRepository : IDisposable
	{
		Task CreateComment(Comment comment);
		Task DeleteAllCommentsOfArticle(int articleId);
	}
}
