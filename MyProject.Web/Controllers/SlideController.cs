using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyProject.Application.Services.Slides;
using MyProject.Application.Services.Slides.Dto;
using MyProject.Web.Controllers.ControllerBase;

namespace MyProject.Web.Controllers
{
    public class SlideController : BaseController
    {
        private readonly ISlideService _slideService;

        public SlideController(ISlideService slideService)
        {
            _slideService = slideService;
        }

        [HttpGet("GetAll")]
        public ActionResult<List<SlideDto>> GetAll()
        {
            var slides = _slideService.GetAll();
            return Ok(slides);
        }
    }
}
