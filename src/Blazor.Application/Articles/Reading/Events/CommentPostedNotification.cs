using Blazor.Domain.Models.Articles;
using MediatR;

namespace Blazor.Application.Articles.Reading.Events
{
	public class CommentPostedNotification : INotification
	{
		public Article Article { get; }
		public Comment Comment { get; }

		public CommentPostedNotification(Article article, Comment comment)
		{
			Article = article;
			Comment = comment;
		}
	}
}
