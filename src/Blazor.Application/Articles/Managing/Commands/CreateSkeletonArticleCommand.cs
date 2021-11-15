using System;
using Blazor.Application.Common;
using MediatR;

namespace Blazor.Application.Articles.Managing.Commands
{
    public class CreateSkeletonArticleCommand : IRequest<CommandResult>
	{

		public Guid AuthorId { get; set; }

		public string AuthorName { get; set; }

		public string Slug { get; set; }

	}


}
