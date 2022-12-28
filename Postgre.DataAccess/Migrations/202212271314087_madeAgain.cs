namespace Postgre.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class madeAgain : DbMigration
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
                        Person_PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.AddressId)
                .ForeignKey("public.person", t => t.Person_PersonId)
                .Index(t => t.Person_PersonId);
            
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
                        Address_AddressId = c.Int(),
                        PersonKnowledge_KnowledgeId = c.Int(),
                        Knowledge_KnowledgeId = c.Int(),
                        Address_AddressId1 = c.Int(),
                    })
                .PrimaryKey(t => t.personId)
                .ForeignKey("public.Addresses", t => t.Address_AddressId)
                .ForeignKey("public.category", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("public.PersonKnowledges", t => t.PersonKnowledge_KnowledgeId)
                .ForeignKey("public.PersonKnowledges", t => t.Knowledge_KnowledgeId)
                .ForeignKey("public.Urgencies", t => t.UrgencyId, cascadeDelete: true)
                .ForeignKey("public.Addresses", t => t.Address_AddressId1)
                .Index(t => t.CategoryId)
                .Index(t => t.UrgencyId)
                .Index(t => t.Address_AddressId)
                .Index(t => t.PersonKnowledge_KnowledgeId)
                .Index(t => t.Knowledge_KnowledgeId)
                .Index(t => t.Address_AddressId1);
            
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
                        Person_PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.knowledgeId)
                .ForeignKey("public.person", t => t.Person_PersonId)
                .Index(t => t.Person_PersonId);
            
            CreateTable(
                "public.Urgencies",
                c => new
                    {
                        urgencyId = c.Int(nullable: false, identity: true),
                        urgencyName = c.String(),
                    })
                .PrimaryKey(t => t.urgencyId);
            
            CreateTable(
                "public.Controls",
                c => new
                    {
                        ControlId = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        AddressId = c.Int(nullable: false),
                        KnowledgeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ControlId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.person", "Address_AddressId1", "public.Addresses");
            DropForeignKey("public.person", "UrgencyId", "public.Urgencies");
            DropForeignKey("public.PersonKnowledges", "Person_PersonId", "public.person");
            DropForeignKey("public.person", "Knowledge_KnowledgeId", "public.PersonKnowledges");
            DropForeignKey("public.person", "PersonKnowledge_KnowledgeId", "public.PersonKnowledges");
            DropForeignKey("public.person", "CategoryId", "public.category");
            DropForeignKey("public.Addresses", "Person_PersonId", "public.person");
            DropForeignKey("public.person", "Address_AddressId", "public.Addresses");
            DropIndex("public.PersonKnowledges", new[] { "Person_PersonId" });
            DropIndex("public.person", new[] { "Address_AddressId1" });
            DropIndex("public.person", new[] { "Knowledge_KnowledgeId" });
            DropIndex("public.person", new[] { "PersonKnowledge_KnowledgeId" });
            DropIndex("public.person", new[] { "Address_AddressId" });
            DropIndex("public.person", new[] { "UrgencyId" });
            DropIndex("public.person", new[] { "CategoryId" });
            DropIndex("public.Addresses", new[] { "Person_PersonId" });
            DropTable("public.Controls");
            DropTable("public.Urgencies");
            DropTable("public.PersonKnowledges");
            DropTable("public.category");
            DropTable("public.person");
            DropTable("public.Addresses");
        }
    }
}
