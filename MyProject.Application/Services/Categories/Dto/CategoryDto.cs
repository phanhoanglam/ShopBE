using MyProject.Application.Abstact;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Application.Services.Categories.Dto
{
    public class CategoryDto: EntityDto<long>
    {
        public string Name { get; set; }
        public string Metatitle { get; set; }
        public long ParentId { get; set; }
        public byte DisplayOrder { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool Status { get; set; }

        public List<CategoryDto> CategoryDtos { get; set; }
    }
}
