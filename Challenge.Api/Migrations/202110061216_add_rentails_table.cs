using Challenge.Api.Domain.Constants;
using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Migrations
{
    [Migration(202110061216)]
    public class _202110061216_add_rentails_table : Migration
    {

        public override void Down()
        {
            Delete.Table(TableConstants.Rentals);
        }

        public override void Up()
        {
            Create.Table(TableConstants.Rentals)
                .WithCommonColumns()
                .WithColumn("MovieId").AsInt32().NotNullable()
                .WithColumn("CustomerEmail").AsString(250).NotNullable()
                .WithColumn("Price").AsDecimal(18, 2).NotNullable();
        }
    }
}
