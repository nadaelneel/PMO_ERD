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
    public class Technical_DefinitionsConfiguration : IEntityTypeConfiguration<Technical_Definitions>
    {
        public void Configure(EntityTypeBuilder<Technical_Definitions> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(i => i.Main)
                    .WithMany(i => i.technical_Definitions)
                    .HasForeignKey(i => i.MainId);
        }
    }
}
