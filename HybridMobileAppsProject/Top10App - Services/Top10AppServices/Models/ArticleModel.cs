using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Top10AppServices.Models
{
    public class ArticleModel
    {
        public int id { get; set; }

        public string image { get; set; }

        public string name { get; set; }

        public string info { get; set; }        
    }
}