using Eventom.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eventom.Configuration
{
    public class CommitteesConfiguration : IEntityTypeConfiguration<Committees>
    {
        public void Configure(EntityTypeBuilder<Committees> builder)
        {
            builder.ToTable("Committees");
            builder.HasKey(v => v.CommitteeId);
            builder.Property(v => v.CommitteeId)
                .ValueGeneratedOnAdd();
        }
    }
    {
    }
}
