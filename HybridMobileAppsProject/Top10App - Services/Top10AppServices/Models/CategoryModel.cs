using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Top10AppServices.Models
{
    public class CategoryModel
    {
        public int id { get; set; }

        public string name { get; set; }

        public IEnumerable<SubcategoryModel> subcategories { get; set; }        
    }
}