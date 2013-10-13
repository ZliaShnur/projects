using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Top10AppServices.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Subcategory> Subcategories { get; set; }

        public Category()
        {
            this.Subcategories = new HashSet<Subcategory>();
        }
    }
}
