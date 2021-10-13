using Challenge.Api.Domain.Constants;
using FluentMigrator;

namespace Migrations
{
    [Migration(202110061217)]
    public class _202110061217_add_sales_table : Migration
    {
        public override void Down()
        {
            Delete.Table(TableConstants.Sales);
        }

        public override void Up()
        {
            Create.Table(TableConstants.Sales)
                .WithCommonColumns()
                .WithColumn("MovieId").AsInt32().NotNullable()
                .WithColumn("CustomerEmail").AsString(250).NotNullable()
                .WithColumn("Price").AsDecimal(18, 2).NotNullable();
        }
    }
}
