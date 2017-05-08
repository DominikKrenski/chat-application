namespace Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAvatarField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.users", "avatar", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.users", "avatar");
        }
    }
}
