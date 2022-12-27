namespace Postgre.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class controlEntity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("public.person", "AddressId", "public.Addresses");
            DropForeignKey("public.person", "KnowledgeId", "public.PersonKnowledges");
            DropIndex("public.person", new[] { "AddressId" });
            DropIndex("public.person", new[] { "KnowledgeId" });
            CreateTable(
                "public.Controls",
                c => new
                    {
                        ControlId = c.Int(nullable: false, identity: true),
                        PersonId = c.String(),
                        AddressId = c.String(),
                        KnowledgeId = c.String(),
                    })
                .PrimaryKey(t => t.ControlId);
            
            AddColumn("public.Addresses", "Person_PersonId", c => c.Int());
            AddColumn("public.person", "Address_AddressId", c => c.Int());
            AddColumn("public.person", "PersonKnowledge_KnowledgeId", c => c.Int());
            AddColumn("public.person", "Knowledge_KnowledgeId", c => c.Int());
            AddColumn("public.person", "Address_AddressId1", c => c.Int());
            AddColumn("public.PersonKnowledges", "Person_PersonId", c => c.Int());
            CreateIndex("public.Addresses", "Person_PersonId");
            CreateIndex("public.person", "Address_AddressId");
            CreateIndex("public.person", "PersonKnowledge_KnowledgeId");
            CreateIndex("public.person", "Knowledge_KnowledgeId");
            CreateIndex("public.person", "Address_AddressId1");
            CreateIndex("public.PersonKnowledges", "Person_PersonId");
            AddForeignKey("public.Addresses", "Person_PersonId", "public.person", "personId");
            AddForeignKey("public.PersonKnowledges", "Person_PersonId", "public.person", "personId");
            AddForeignKey("public.person", "Address_AddressId1", "public.Addresses", "AddressId");
            AddForeignKey("public.person", "Address_AddressId", "public.Addresses", "AddressId");
            AddForeignKey("public.person", "Knowledge_KnowledgeId", "public.PersonKnowledges", "knowledgeId");
            AddForeignKey("public.person", "PersonKnowledge_KnowledgeId", "public.PersonKnowledges", "knowledgeId");
        }
        
        public override void Down()
        {
            DropForeignKey("public.person", "PersonKnowledge_KnowledgeId", "public.PersonKnowledges");
            DropForeignKey("public.person", "Knowledge_KnowledgeId", "public.PersonKnowledges");
            DropForeignKey("public.person", "Address_AddressId", "public.Addresses");
            DropForeignKey("public.person", "Address_AddressId1", "public.Addresses");
            DropForeignKey("public.PersonKnowledges", "Person_PersonId", "public.person");
            DropForeignKey("public.Addresses", "Person_PersonId", "public.person");
            DropIndex("public.PersonKnowledges", new[] { "Person_PersonId" });
            DropIndex("public.person", new[] { "Address_AddressId1" });
            DropIndex("public.person", new[] { "Knowledge_KnowledgeId" });
            DropIndex("public.person", new[] { "PersonKnowledge_KnowledgeId" });
            DropIndex("public.person", new[] { "Address_AddressId" });
            DropIndex("public.Addresses", new[] { "Person_PersonId" });
            DropColumn("public.PersonKnowledges", "Person_PersonId");
            DropColumn("public.person", "Address_AddressId1");
            DropColumn("public.person", "Knowledge_KnowledgeId");
            DropColumn("public.person", "PersonKnowledge_KnowledgeId");
            DropColumn("public.person", "Address_AddressId");
            DropColumn("public.Addresses", "Person_PersonId");
            DropTable("public.Controls");
            CreateIndex("public.person", "KnowledgeId");
            CreateIndex("public.person", "AddressId");
            AddForeignKey("public.person", "KnowledgeId", "public.PersonKnowledges", "knowledgeId", cascadeDelete: true);
            AddForeignKey("public.person", "AddressId", "public.Addresses", "AddressId", cascadeDelete: true);
        }
    }
}
