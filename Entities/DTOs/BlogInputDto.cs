using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class BlogInputDto
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public string Photo { get; set; }
        public int AuthorId { get; set; }
        public int BlogCategoryId { get; set; }
      
    }
}
