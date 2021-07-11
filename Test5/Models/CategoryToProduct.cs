using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gift.Models
{
    public class CategoryToProduct : BaseEntity
    {
        public int SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }



    }
}
