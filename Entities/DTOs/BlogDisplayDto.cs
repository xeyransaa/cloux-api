using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class BlogDisplayDto
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public string Photo {  get; set; }

        public string AuthorName { get; set; }
        public string AuthorPhoto {  get; set; }
        public string BlogCategoryName { get; set; }
        public DateOnly CreatedDate { get; set; }
       
    }
}
