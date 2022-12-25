namespace Postgre.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class personknowledgeadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        AppealDate = c.String(),
                        DetectDate = c.String(),
                        Country = c.String(),
                        City = c.String(),
                        District = c.String(),
                        Hometown = c.String(),
                        PhoneNumberTwo = c.String(),
                        PhoneNumberOne = c.String(),
                        Street = c.String(),
                        Build = c.String(),
                        BuildNumber = c.String(),
                    })
                .PrimaryKey(t => t.AddressId);
            
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
                        blood = c.String(),
                        work = c.String(),
                        income = c.String(),
                        outgoing = c.String(),
                        debt = c.String(),
                        aid = c.String(),
                        stuff = c.String(),
                        student = c.String(),
                        partnerLocalId = c.String(),
                        childOneLocalId = c.String(),
                        childTwoLocalId = c.String(),
                        childThreeLocalId = c.String(),
                        childForthLocalId = c.String(),
                        childFifthLocalId = c.String(),
                        childSixthLocalId = c.String(),
                        CategoryId = c.Int(nullable: false),
                        AddressId = c.Int(nullable: false),
                        UrgencyId = c.Int(nullable: false),
                        KnowledgeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.personId)
                .ForeignKey("public.Addresses", t => t.AddressId, cascadeDelete: true)
                .ForeignKey("public.category", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("public.PersonKnowledges", t => t.KnowledgeId, cascadeDelete: true)
                .ForeignKey("public.Urgencies", t => t.UrgencyId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.AddressId)
                .Index(t => t.UrgencyId)
                .Index(t => t.KnowledgeId);
            
            CreateTable(
                "public.category",
                c => new
                    {
                        categoryId = c.Int(nullable: false, identity: true),
                        categoryName = c.String(),
                    })
                .PrimaryKey(t => t.categoryId);
            
            CreateTable(
                "public.PersonKnowledges",
                c => new
                    {
                        knowledgeId = c.Int(nullable: false, identity: true),
                        knowledge = c.String(),
                    })
                .PrimaryKey(t => t.knowledgeId);
            
            CreateTable(
                "public.Urgencies",
                c => new
                    {
                        UrgencyId = c.Int(nullable: false, identity: true),
                        UrgencyName = c.String(),
                    })
                .PrimaryKey(t => t.UrgencyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.person", "UrgencyId", "public.Urgencies");
            DropForeignKey("public.person", "KnowledgeId", "public.PersonKnowledges");
            DropForeignKey("public.person", "CategoryId", "public.category");
            DropForeignKey("public.person", "AddressId", "public.Addresses");
            DropIndex("public.person", new[] { "KnowledgeId" });
            DropIndex("public.person", new[] { "UrgencyId" });
            DropIndex("public.person", new[] { "AddressId" });
            DropIndex("public.person", new[] { "CategoryId" });
            DropTable("public.Urgencies");
            DropTable("public.PersonKnowledges");
            DropTable("public.category");
            DropTable("public.person");
            DropTable("public.Addresses");
        }
    }
}
