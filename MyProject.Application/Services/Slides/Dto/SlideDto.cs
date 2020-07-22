using MyProject.Application.Abstact;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Application.Services.Slides.Dto
{
    public class SlideDto : EntityDto<byte>
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public byte DisplayOrder { get; set; }
        public bool Status { get; set; }
        public string Alt { get; set; }
        public bool Active { get; set; }
    }
}
