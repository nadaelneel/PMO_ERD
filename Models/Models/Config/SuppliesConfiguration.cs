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
    public class SuppliesConfiguration : IEntityTypeConfiguration<Supplies>
    {
        public void Configure(EntityTypeBuilder<Supplies> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(i => i.Main)
                    .WithOne(i => i.supplies)
                    .HasForeignKey<Supplies>(i => i.MainId);
        }
    }
}
