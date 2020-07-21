using AutoMapper;
using MyProject.Application.Services.Categories.Dto;
using MyProject.Core.Entity;
using MyProject.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Application.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category, long> _repository;
        private readonly Mapper _mapper;

        public CategoryService(IRepository<Category, long> repository, Mapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<CategoryDto>> GetAll()
        {
            var categories = _repository.GetAll().Where(c => c.ParentId == null).ToList();
            var cateoriesDto = _mapper.Map<List<CategoryDto>>(categories);
            GetChildren(cateoriesDto);
            return cateoriesDto;
        }

        private void GetChildren(List<CategoryDto> list)
        {
            list.Add(new CategoryDto
            {
                Id = 1,
            });
        }
    }
}
