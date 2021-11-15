using Blazor.Domain.Models.Articles;
using MediatR;

namespace Blazor.Application.Articles.Managing.Events
{
	public class ArticleCreatedNotification : INotification
	{
		public Article Article { get; }

		public ArticleCreatedNotification(Article article)
		{
			Article = article;
		}
	}
}
