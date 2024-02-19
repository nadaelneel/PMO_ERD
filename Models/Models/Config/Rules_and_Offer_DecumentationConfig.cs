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
    public class Rules_and_Offer_DecumentationConfig : IEntityTypeConfiguration<Rules_and_Offer_Decumentation>
    {
        public void Configure(EntityTypeBuilder<Rules_and_Offer_Decumentation> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(i => i.Main)
                    .WithOne(i => i.Rules_and_Offer)
                    .HasForeignKey<Rules_and_Offer_Decumentation>(i => i.MainId);
        }
    }
}
