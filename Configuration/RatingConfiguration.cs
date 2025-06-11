using Eventom.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Eventom.Configuration
{
    public class RatingConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.ToTable("Reating");
            builder.HasKey(v => v.RatingID);
            builder.Property(v => v.RatingID)
                .ValueGeneratedOnAdd();
        }
    }
}
