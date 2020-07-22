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
        private readonly IMapper _mapper;

        public CategoryService(IRepository<Category, long> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public List<CategoryDto> GetAll()
        {
            var categories = _repository.GetAll().Where(c => c.ParentId == null).ToList();
            var categoriesDto = _mapper.Map<List<CategoryDto>>(categories);

            foreach (var item in categoriesDto)
            {
                GetChildren(item);
            }

            return categoriesDto;
        }

        private void GetChildren(CategoryDto item)
        {
            var categoriesChild = _repository.GetAll().Where(c => c.ParentId == item.Id).ToList();

            var categoriesChildDto = _mapper.Map<List<CategoryDto>>(categoriesChild);

            if (categoriesChildDto != null)
            {
                item.CategoryDtos = categoriesChildDto;

                foreach (var jtem in item.CategoryDtos)
                {
                    GetChildren(jtem);
                }
            }
        }

        public List<CategoryDto> GetCategoryShowHome()
        {
            var categories = _repository.GetAll().Where(c => c.ShowHome == true).ToList();
            var categoriesDto = _mapper.Map<List<CategoryDto>>(categories);
            return categoriesDto;
        }
    }
}
