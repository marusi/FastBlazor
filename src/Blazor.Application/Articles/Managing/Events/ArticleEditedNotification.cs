using Blazor.Domain.Models.Articles;
using MediatR;

namespace CoreWiki.Application.Articles.Managing.Events
{
	public class ArticleEditedNotification: INotification
	{
		public Article Editedarticle { get; }

		public ArticleEditedNotification(Article editedarticle)
		{
			Editedarticle = editedarticle;
		}
	}
}
