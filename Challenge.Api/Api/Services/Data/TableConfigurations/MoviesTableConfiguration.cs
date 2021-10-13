using Challenge.Api.Domain.Constants;
using Challenge.Api.Domain.Entities;
using Challenge.Api.Services.Data.TableConfigurations.AppServices.Data.TableConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Challenge.Api.Services.Data.TableConfigurations
{
    public class MoviesTableConfiguration : TableConfiguration<Movie>
    {
        public override void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable(TableConstants.Movies);
        }
    }
}
