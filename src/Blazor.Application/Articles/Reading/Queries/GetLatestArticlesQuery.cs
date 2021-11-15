using System.Collections.Generic;
using Blazor.Application.Articles.Reading.Dto;
using MediatR;

namespace Blazor.Application.Articles.Reading.Queries
{
	public class GetLatestArticlesQuery: IRequest<List<ArticleReadingDto>>
	{
		public int NumOfArticlesToGet { get; }

		public GetLatestArticlesQuery(int numOfArticlesToGet)
		{
			NumOfArticlesToGet = numOfArticlesToGet;
		}
	}
}
