using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.EntityLayer.Dtos.Category
{
    public class CreateCategoryDto
    {
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
