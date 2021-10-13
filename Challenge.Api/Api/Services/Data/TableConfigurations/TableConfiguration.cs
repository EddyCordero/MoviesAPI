using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Challenge.Api.Domain.Entities;

namespace Challenge.Api.Services.Data.TableConfigurations
{
    namespace AppServices.Data.TableConfigurations
    {
        public abstract class TableConfiguration<T> : IEntityTypeConfiguration<T> where T : Entity
        {
            protected void CommonColumnsConfiguration(EntityTypeBuilder<T> builder)
            {
                builder.HasKey(p => p.Id);
                builder.Property(p => p.CreatedAt).IsRequired();
                builder.Property(p => p.IsActive).IsRequired();
            }

            public abstract void Configure(EntityTypeBuilder<T> builder);
        }
    }

}
