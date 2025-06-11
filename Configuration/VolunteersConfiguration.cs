using Eventom.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eventom.Configuration
{
    public class VolunteersConfiguration : IEntityTypeConfiguration<Volunteers>
    {
        public void Configure(EntityTypeBuilder<Volunteers> builder)
        {
            builder.ToTable("Volunteers");
            builder.HasKey(v => v.VolunteerId);
            builder.Property(v => v.VolunteerId)
                .ValueGeneratedOnAdd();
        }
    }
    
    }

