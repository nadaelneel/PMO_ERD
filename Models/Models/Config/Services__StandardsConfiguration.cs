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
    public class Services__StandardsConfiguration : IEntityTypeConfiguration<Services__Standards>
    {
        public void Configure(EntityTypeBuilder<Services__Standards> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(i => i.Main)
                    .WithOne(i => i.services__Standards)
                        .HasForeignKey<Services__Standards>(i => i.MainId);
        }
    }
}
