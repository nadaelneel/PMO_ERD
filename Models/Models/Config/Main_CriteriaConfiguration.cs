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
    public class Main_CriteriaConfiguration : IEntityTypeConfiguration<Main_Criteria>
    {
        public void Configure(EntityTypeBuilder<Main_Criteria> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(i => i.Main)
                .WithMany(i => i.main_Criterias)
                .HasForeignKey(i => i.MainId);
                
        }
    }
}
