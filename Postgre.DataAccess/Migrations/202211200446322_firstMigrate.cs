namespace Postgre.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigrate : DbMigration
    {
        public override void Up()
        {
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
                    })
                .PrimaryKey(t => t.personId);
            
        }
        
        public override void Down()
        {
            DropTable("public.person");
        }
    }
}
