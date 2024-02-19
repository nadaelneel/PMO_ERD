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
    public class Classification_fieldConfig : IEntityTypeConfiguration<Classification_field>
    {
        public void Configure(EntityTypeBuilder<Classification_field> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(i => i.Main)
                .WithOne(i => i.classification_field)
                .HasForeignKey<Classification_field>(i => i.MainId);
        }
    }
}
