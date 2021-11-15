﻿using AutoMapper;
using Blazor.Application.Articles.Managing.Commands;
using Blazor.Application.Articles.Managing.Dto;
using Blazor.Domain.Models.Articles;

namespace Blazor.Application.Articles.Managing
{
	public class ArticleManagingProfile: Profile
	{
		public ArticleManagingProfile()
		{
			CreateMap<CreateNewArticleCommand, Article>()
				.ForMember(d => d.Id, m=> m.Ignore())
				.ForMember(d => d.Version, m => m.MapFrom(src => 1))
				.ForMember(d => d.Published, m => m.Ignore())
				.ForMember(d => d.Comments, m => m.Ignore())
				.ForMember(d => d.History, m => m.Ignore())
				.ForMember(d => d.ViewCount, m => m.MapFrom(src => 0))
				.ForMember(d => d.Slug, m => m.Ignore())
				;

			CreateMap<CreateSkeletonArticleCommand, Article>()
				.ForMember(d => d.Id, m => m.Ignore())
				.ForMember(d => d.Version, m => m.MapFrom(src => 1))
				.ForMember(d => d.Published, m => m.Ignore())
				.ForMember(d => d.Comments, m => m.Ignore())
				.ForMember(d => d.History, m => m.Ignore())
				.ForMember(d => d.ViewCount, m => m.MapFrom(src => 0))
				.ForMember(d => d.Topic, m => m.MapFrom(s => Article.SlugToTopic(s.Slug)))
				.ForMember(d => d.Content, m => m.MapFrom(""));

			CreateMap<Article, ArticleManageDto>();
		}
	}
}
