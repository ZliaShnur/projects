using Top10AppServices.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top10AppServices.DataLayer.Mappings
{
    class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(30);
        }
    }
}
