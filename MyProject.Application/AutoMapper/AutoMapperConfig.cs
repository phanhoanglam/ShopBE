using AutoMapper;
using MyProject.Application.Services.Categories.Dto;
using MyProject.Application.Services.Slides.Dto;
using MyProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Application.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        //public static MapperConfiguration RegisterMappings()
        //{
        //    return new MapperConfiguration(cfg =>
        //    {
        //        cfg.AddProfile(new ModelToModelDtoMapping());
        //        cfg.AddProfile(new ModelDtoToModelMapping());
        //    });
        //}

        public AutoMapperConfig()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<CategoryDto, Category>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Slide, SlideDto>();
            CreateMap<SlideDto, Slide>();
        }
    }
}
