using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Top10AppServices.Models
{
    public class Story
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Intro { get; set; }

        public virtual ICollection<Article> Articles { get; set; }

        public virtual Subcategory Subcategory { get; set; }

        public Story()
        {
            this.Articles = new HashSet<Article>();
        }
    }
}
