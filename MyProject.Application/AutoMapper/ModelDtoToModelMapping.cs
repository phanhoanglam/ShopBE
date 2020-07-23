using AutoMapper;
using MyProject.Application.Services.Categories.Dto;
using MyProject.Application.Services.Slides.Dto;
using MyProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Application.AutoMapper
{
    public class ModelDtoToModelMapping : Profile
    {
        public ModelDtoToModelMapping()
        {
            CreateMap<CategoryDto, Category>();
            CreateMap<SlideDto, Slide>();
        }
    }
}
