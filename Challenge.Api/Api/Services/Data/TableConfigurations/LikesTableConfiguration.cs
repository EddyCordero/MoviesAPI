using Challenge.Api.Domain.Constants;
using Challenge.Api.Domain.Entities;
using Challenge.Api.Services.Data.TableConfigurations.AppServices.Data.TableConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Challenge.Api.Services.Data.TableConfigurations
{
    public class LikesTableConfiguration : TableConfiguration<Like>
    {
        public override void Configure(EntityTypeBuilder<Like> builder)
        {
            builder.ToTable(TableConstants.Likes);
        }
    }
}
