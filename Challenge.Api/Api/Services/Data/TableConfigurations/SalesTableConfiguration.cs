using Challenge.Api.Domain.Constants;
using Challenge.Api.Domain.Entities;
using Challenge.Api.Services.Data.TableConfigurations.AppServices.Data.TableConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Challenge.Api.Services.Data.TableConfigurations
{
    public class SalesTableConfiguration : TableConfiguration<Sale>
    {
        public override void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable(TableConstants.Sales);
        }
    }
}
