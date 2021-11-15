using System;
using Blazor.Application.Common;
using MediatR;

namespace Blazor.Application.Articles.Managing.Commands
{
    public class CreateNewArticleCommand : IRequest<CommandResult>
	{

		public string Topic { get; set; }

		public string Content { get; set; }

		public Guid AuthorId { get; set; }

		public string AuthorName { get; set; }

	}


}
