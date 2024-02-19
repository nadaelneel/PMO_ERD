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
    public class ProjectDetailsConfiguration : IEntityTypeConfiguration<ProjectDetails>
    {
        public void Configure(EntityTypeBuilder<ProjectDetails> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(i => i.Main)
                 .WithOne(i => i.projectDetails)
                 .HasForeignKey<ProjectDetails>(i => i.MainId);
        }
    }
}
