using Eventom.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Eventom.Configuration
{
    public class EventsConfiguration : IEntityTypeConfiguration<Events>
    {
        public void Configure(EntityTypeBuilder<Events> builder)
        {
            builder.ToTable("Event");
            builder.HasKey(v => v.EventId);
            builder.Property(v => v.EventId)
                .ValueGeneratedOnAdd();
        }
    }
}
