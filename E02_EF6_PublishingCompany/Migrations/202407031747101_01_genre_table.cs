namespace E02_EF6_PublishingCompany.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _01_genre_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        PublishingCompanyId = c.Int(nullable: false),
                        GenreId = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 100),
                        ISBN = c.String(nullable: false, maxLength: 13),
                    })
                .PrimaryKey(t => t.BookId)
                .ForeignKey("dbo.Genre", t => t.GenreId, cascadeDelete: true)
                .ForeignKey("dbo.PublishingCompany", t => t.PublishingCompanyId, cascadeDelete: true)
                .Index(t => t.PublishingCompanyId)
                .Index(t => t.GenreId);
            
            CreateTable(
                "dbo.Genre",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        Genre = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.GenreId);
            
            CreateTable(
                "dbo.PublishingCompany",
                c => new
                    {
                        PublishingCompanyId = c.Int(nullable: false, identity: true),
                        Publisher = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.PublishingCompanyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Book", "PublishingCompanyId", "dbo.PublishingCompany");
            DropForeignKey("dbo.Book", "GenreId", "dbo.Genre");
            DropIndex("dbo.Book", new[] { "GenreId" });
            DropIndex("dbo.Book", new[] { "PublishingCompanyId" });
            DropTable("dbo.PublishingCompany");
            DropTable("dbo.Genre");
            DropTable("dbo.Book");
        }
    }
}
