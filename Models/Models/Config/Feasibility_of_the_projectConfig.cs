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
    public class Feasibility_of_the_projectConfig : IEntityTypeConfiguration<Feasibility_of_the_project>
    {
        public void Configure(EntityTypeBuilder<Feasibility_of_the_project> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(i => i.Main)
                .WithOne(i => i.feasibility_Of_The_Project)
                .HasForeignKey<Feasibility_of_the_project>(i => i.MainId);
        }
    }
}
