using AutoMapper;
using Blazor.Application.Articles.Reading.Commands;
using Blazor.Application.Articles.Reading.Dto;
using Blazor.Domain.Models.Articles;

namespace Blazor.Application.Articles.Reading
{
	public class ArticleReadingProfile: Profile
	{

		public ArticleReadingProfile()
		{
			CreateMap<Comment, CommentDto>();
			CreateMap<CreateCommentDto, Comment>()
				.ForMember(d => d.Id, m => m.Ignore());
			CreateMap<CreateNewCommentCommand, CreateCommentDto>();
			CreateMap<Article, ArticleReadingDto>();
			CreateMap<SlugHistory, SlugHistoryDto>()
				.ForMember( d => d.Version, m => m.MapFrom(s => s.Article.Version))
				.ForMember(d => d.Content, m => m.MapFrom(s => s.Article.Content))
				.ForMember(d => d.AuthorName, m => m.MapFrom(s => s.Article.AuthorName))
				.ForMember(d => d.Published, m => m.MapFrom(s => s.Article.Published));
			CreateMap<CommentDto, Comment>();
		}
	}
}
