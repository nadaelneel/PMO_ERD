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
    public class Work_ServicesConfiguration : IEntityTypeConfiguration<Work_Services>
    {
        public void Configure(EntityTypeBuilder<Work_Services> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(i => i.Main)
                    .WithOne(i => i.work_Services)
                    .HasForeignKey<Work_Services>(i => i.MainId);
        }
    }
}
