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
    public class Team_Work_StandardsConfig : IEntityTypeConfiguration<Team_Work_Standards>
    {
        public void Configure(EntityTypeBuilder<Team_Work_Standards> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(i => i.Main)
                .WithMany(i => i.Work_Standards)
                .HasForeignKey(i => i.MainId);
        }
    }
}
