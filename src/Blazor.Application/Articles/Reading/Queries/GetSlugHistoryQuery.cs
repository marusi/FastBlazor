using Blazor.Application.Articles.Reading.Dto;
using MediatR;

namespace Blazor.Application.Articles.Reading.Queries
{
	public class GetSlugHistoryQuery : IRequest<SlugHistoryDto>
	{

		public GetSlugHistoryQuery(string historicalSlug)
		{
			this.HistoricalSlug = historicalSlug;
		}

		public string HistoricalSlug { get; }
	}


}
