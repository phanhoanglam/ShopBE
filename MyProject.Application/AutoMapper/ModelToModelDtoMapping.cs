using AutoMapper;
using MyProject.Application.Services.Categories.Dto;
using MyProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Application.AutoMapper
{
    public class ModelToModelDtoMapping : Profile
    {
        public ModelToModelDtoMapping()
        {
            CreateMap<Category, CategoryDto>();
        }
    }
}
