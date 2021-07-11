using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gift.Models
{
    public class SubCategory : BaseEntity
    {
        public int? ParentCategoryId { get; set; }
        public string Name { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Category ParentCategory { get; set; }
        public virtual ICollection<CategoryToProduct> CategoryToProducts { get; set; }



    }
}
