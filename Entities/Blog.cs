using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Blog: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Photo {  get; set; }

        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public int BlogCategoryId { get; set; }
        public virtual BlogCategory BlogCategory { get; set; }
        public DateOnly CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
