using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static System.Net.Mime.MediaTypeNames;

namespace Eventom.Configuration
{
    public class ApplicationConfiguration : IEntityTypeConfiguration<Application>
    {
        public void Configure(EntityTypeBuilder<Application> builder)
        {
            builder.ToTable("Application");
            builder.HasKey(a => a.ApplicationId);
            builder.Property(a => a.ApplicationId)
                .ValueGeneratedOnAdd();
        }

        
    }
    {
    }
}
