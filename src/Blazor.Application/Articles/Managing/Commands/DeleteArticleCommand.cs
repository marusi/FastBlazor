using Blazor.Application.Common;
using MediatR;

namespace Blazor.Application.Articles.Managing.Commands
{
	public class DeleteArticleCommand : IRequest<CommandResult>
	{
		public string Slug { get; }

		public DeleteArticleCommand(string slug)
		{
			Slug = slug;
		}
	}
}
