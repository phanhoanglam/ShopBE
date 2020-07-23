using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyProject.Application.Services.Categories;
using MyProject.Application.Services.Categories.Dto;
using MyProject.Web.Controllers.ControllerBase;

namespace MyProject.Web.Controllers
{
    public class CategoryController : BaseController
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpGet()]
        public ActionResult<List<CategoryDto>> GetAll()
        {
            var categories = _categoryService.GetAll();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public ActionResult<CategoryDto> Get(long id)
        {
            return null;
        }

        [HttpGet()]
        public ActionResult<List<CategoryDto>> GetCategoryShowHome()
        {
            var categories = _categoryService.GetCategoryShowHome();
            return Ok(categories);
        }
    }
}
