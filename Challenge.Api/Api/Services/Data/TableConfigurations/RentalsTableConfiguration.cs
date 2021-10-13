using Challenge.Api.Domain.Constants;
using Challenge.Api.Domain.Entities;
using Challenge.Api.Services.Data.TableConfigurations.AppServices.Data.TableConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Challenge.Api.Services.Data.TableConfigurations
{
    public class RentalsTableConfiguration : TableConfiguration<Rental>
    {
        public override void Configure(EntityTypeBuilder<Rental> builder)
        {
            builder.ToTable(TableConstants.Rentals);
        }
    }
}
