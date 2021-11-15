using Blazor.Domain.Models.Articles;
using MediatR;

namespace Blazor.Application.Articles.Managing.Events
{
	public class ArticleDeletedNotification : INotification
	{
		public Article Article { get; }

		public ArticleDeletedNotification(Article article)
		{
			Article = article;
		}
	}
}
