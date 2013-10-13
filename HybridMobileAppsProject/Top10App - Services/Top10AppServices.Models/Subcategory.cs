using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top10AppServices.Models
{
    public class Subcategory
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Story> Stories { get; set; }

        public virtual Category Category { get; set; }

        public Subcategory()
        {
            this.Stories = new HashSet<Story>();
        }
    }
}
