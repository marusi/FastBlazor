using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Blazor.Application.Articles.Reading.Dto;
using Blazor.Application.Articles.Reading.Exceptions;
using Blazor.Application.Common;
using MediatR;

namespace Blazor.Application.Articles.Reading.Commands
{
	public class CreateNewCommentCommandHandler : IRequestHandler<CreateNewCommentCommand, CommandResult>
	{
		private readonly IArticleReadingService _articleReadingService;
		private readonly IMapper _mapper;

		public CreateNewCommentCommandHandler(IArticleReadingService articleReadingService, IMapper mapper)
		{
			_articleReadingService = articleReadingService;
			_mapper = mapper;
		}

		public async Task<CommandResult> Handle(CreateNewCommentCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var comment = _mapper.Map<CreateCommentDto>(request);
				await _articleReadingService.CreateComment(comment);

				return CommandResult.Success();
			}
			catch (Exception ex)
			{
				return CommandResult.Error(new CreateCommentException("There was an error creating the comment", ex));
			}
		}
	}
}
