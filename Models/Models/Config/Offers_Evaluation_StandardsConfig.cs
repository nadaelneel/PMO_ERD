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
    public class Offers_Evaluation_StandardsConfig : IEntityTypeConfiguration<Offers_Evaluation_Standards>
    {
        public void Configure(EntityTypeBuilder<Offers_Evaluation_Standards> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(i => i.Main)
                .WithMany(i => i.offers_Evaluations)
                .HasForeignKey(i => i.MainId);
        }
    }
}
