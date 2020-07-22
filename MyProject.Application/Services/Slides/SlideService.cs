using AutoMapper;
using MyProject.Application.Services.Slides.Dto;
using MyProject.Core.Entity;
using MyProject.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProject.Application.Services.Slides
{
    public class SlideService : ISlideService
    {
        private readonly IRepository<Slide, byte> _repository;
        private readonly IMapper _mapper;

        public SlideService(IRepository<Slide, byte> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<SlideDto> GetAll()
        {
            var slides = _repository.GetAll().Where(s => s.Status == true).ToList();
            var slidesDto = _mapper.Map<List<SlideDto>>(slides);
            return slidesDto;
        }
    }
}
