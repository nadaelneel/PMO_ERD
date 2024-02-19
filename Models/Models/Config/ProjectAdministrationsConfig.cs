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
    public class ProjectAdministrationsConfig : IEntityTypeConfiguration<ProjectAdministrations>
    {
        public void Configure(EntityTypeBuilder<ProjectAdministrations> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(i => i.projectDetails)
                .WithMany(i => i.Administration)
                .HasForeignKey(i => i.ProJectDetailsId);

            builder.HasOne(i => i.administration)
                .WithMany(i => i.projectAdministrations)
                .HasForeignKey(i => i.AdministrationId);
        }
    }
}
