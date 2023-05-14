namespace IBE.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Managers", "Enable", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "Enable", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Enable");
            DropColumn("dbo.Managers", "Enable");
        }
    }
}
