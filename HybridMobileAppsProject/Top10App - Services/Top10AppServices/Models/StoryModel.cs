using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Top10AppServices.Models
{
    public class StoryModel
    {
        public int id { get; set; }

        public string name { get; set; }

        public string intro { get; set; }

        public IEnumerable<ArticleModel> subcategories { get; set; }
    }
}