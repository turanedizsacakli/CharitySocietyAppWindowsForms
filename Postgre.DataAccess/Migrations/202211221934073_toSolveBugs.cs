namespace Postgre.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class toSolveBugs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.category",
                c => new
                    {
                        categoryId = c.Int(nullable: false, identity: true),
                        categoryname = c.String(),
                    })
                .PrimaryKey(t => t.categoryId);
            
            CreateTable(
                "public.person",
                c => new
                    {
                        personId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        surname = c.String(),
                        fathername = c.String(),
                        mothername = c.String(),
                        nationality = c.String(),
                        birthday = c.String(),
                        birthcountry = c.String(),
                        localid = c.String(),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.personId)
                .ForeignKey("public.category", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.person", "CategoryId", "public.category");
            DropIndex("public.person", new[] { "CategoryId" });
            DropTable("public.person");
            DropTable("public.category");
        }
    }
}
