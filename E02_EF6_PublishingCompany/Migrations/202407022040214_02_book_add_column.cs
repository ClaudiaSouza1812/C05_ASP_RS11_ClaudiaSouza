namespace E02_EF6_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _02_book_add_column : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Book", "Type", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Book", "Type");
        }
    }
}
