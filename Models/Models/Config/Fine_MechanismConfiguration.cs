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
    public class Fine_MechanismConfiguration : IEntityTypeConfiguration<Fine_Mechanism>
    {
        public void Configure(EntityTypeBuilder<Fine_Mechanism> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(i => i.Main)
                .WithMany(i => i.fine_Mechanisms)
                .HasForeignKey(i => i.MainId);
        }
    }
}
