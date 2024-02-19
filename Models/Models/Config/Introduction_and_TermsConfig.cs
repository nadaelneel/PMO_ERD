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
    public class Introduction_and_TermsConfig : IEntityTypeConfiguration<Introduction_and_Terms>
    {
        public void Configure(EntityTypeBuilder<Introduction_and_Terms> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(i => i.Main)
                    .WithOne(i => i.introduction_And_Terms)
                    .HasForeignKey<Introduction_and_Terms>(i => i.MainId);
            builder.HasOne(i => i.Represintator_Info)
                    .WithOne(i => i.introduction_And_Terms)
                    .HasForeignKey<Introduction_and_Terms>(i => i.Represintator_Info_Id);
        }
    }
}
