using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Models;

namespace Models.Config
{
    public class MainConfiguration : IEntityTypeConfiguration<Main>
    {
        public void Configure(EntityTypeBuilder<Main> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
