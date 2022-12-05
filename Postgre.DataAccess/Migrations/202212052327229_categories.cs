namespace Postgre.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categories : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.category",
                c => new
                    {
                        categoryId = c.Int(nullable: false, identity: true),
                        categoryName = c.String(),
                    })
                .PrimaryKey(t => t.categoryId);
            
            AddColumn("public.person", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("public.person", "CategoryId");
            AddForeignKey("public.person", "CategoryId", "public.category", "categoryId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("public.person", "CategoryId", "public.category");
            DropIndex("public.person", new[] { "CategoryId" });
            DropColumn("public.person", "CategoryId");
            DropTable("public.category");
        }
    }
}
