using Challenge.Api.Domain.Constants;
using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Migrations
{
    [Migration(202110060850)]
    public class _202110060850_add_likes_table : Migration
    {
        public override void Down()
        {
            Delete.Table(TableConstants.Likes);
        }

        public override void Up()
        {
            Create.Table(TableConstants.Likes)
                .WithCommonColumns()
                .WithColumn("MovieId").AsInt32().Nullable()
                .WithColumn("CustomerEmail").AsString(int.MaxValue).NotNullable();
        }
    }
}
