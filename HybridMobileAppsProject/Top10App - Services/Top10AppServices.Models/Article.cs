using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Top10AppServices.Models
{
    public class Article
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public string Name { get; set; }

        public string Info { get; set; }

        public virtual Story Story { get; set; }
    }
}
