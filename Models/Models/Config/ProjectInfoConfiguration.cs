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
    public class ProjectInfoConfiguration : IEntityTypeConfiguration<ProjectInfo>
    {
        public void Configure(EntityTypeBuilder<ProjectInfo> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(i => i.Main)
              .WithOne(i => i.projectInfo)
              .HasForeignKey<ProjectInfo>(i => i.MainId);
            builder.HasOne(i => i.Project_Manger)
              .WithOne(i => i.Project_Manger)
              .HasForeignKey<ProjectInfo>(i => i.Project_MangerId);
            builder.HasOne(i => i.Project_Owner)
              .WithOne(i => i.Project_Owner)
              .HasForeignKey<ProjectInfo>(i => i.Project_OwnerId);
        }
    }
}
