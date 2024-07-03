﻿namespace E02_EF6_PublishingCompany.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _01_initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        PublishingCompanyId = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 100),
                        ISBN = c.String(nullable: false, maxLength: 13),
                    })
                .PrimaryKey(t => t.BookId)
                .ForeignKey("dbo.PublishingCompany", t => t.PublishingCompanyId, cascadeDelete: true)
                .Index(t => t.PublishingCompanyId);
            
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
            DropIndex("dbo.Book", new[] { "PublishingCompanyId" });
            DropTable("dbo.PublishingCompany");
            DropTable("dbo.Book");
        }
    }
}