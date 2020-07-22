using MyProject.Application.Services.Slides.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Application.Services.Slides
{
    public interface ISlideService
    {
        List<SlideDto> GetAll();
    }
}
