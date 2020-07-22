using MyProject.Application.Services.Categories.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Application.Services.Categories
{
    public interface ICategoryService
    {
        List<CategoryDto> GetAll();
        List<CategoryDto> GetCategoryShowHome();
    }
}
