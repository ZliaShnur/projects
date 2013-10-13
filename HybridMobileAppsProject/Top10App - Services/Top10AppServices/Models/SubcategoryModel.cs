using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Top10AppServices.Models
{
    public class SubcategoryModel
    {
        public int id { get; set; }

        public string name { get; set; }

        public IEnumerable<StoryModel> subcategories { get; set; }        
    }
}