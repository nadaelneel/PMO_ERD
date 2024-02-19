using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Config
{
    public class DependenciesConfiguration : IEntityTypeConfiguration<Dependencies>
    {
        public void Configure(EntityTypeBuilder<Dependencies> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(i => i.Main)
                .WithOne(i => i.dependencie)
                .HasForeignKey<Dependencies>(i => i.MainId);
        }
    }
}
