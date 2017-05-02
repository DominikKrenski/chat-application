namespace Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        login = c.String(nullable: false, maxLength: 10),
                        password = c.String(nullable: false, maxLength: 60),
                        name = c.String(nullable: false, maxLength: 50),
                        surname = c.String(nullable: false, maxLength: 50),
                        sex = c.String(nullable: false),
                        age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.users");
        }
    }
}
