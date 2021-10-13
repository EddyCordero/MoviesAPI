using Challenge.Api.Domain.Constants;
using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Migrations
{
    [Migration(202110061215)]
    public class _202110061215_add_movies_table : Migration
    {
        public override void Down()
        {
            Delete.Table(TableConstants.Movies);
        }

        public override void Up()
        {
            Create.Table(TableConstants.Movies)
                .WithCommonColumns()
                .WithColumn("Title").AsString(50).NotNullable()
                .WithColumn("Description").AsString(250).NotNullable()
                .WithColumn("Stock").AsInt32().NotNullable()
                .WithColumn("RentalPrice").AsDecimal(18, 2).NotNullable()
                .WithColumn("SalePrice").AsDecimal(18, 2).NotNullable()
                .WithColumn("Available").AsBoolean().WithDefaultValue(true).NotNullable();
        }
    }
}
