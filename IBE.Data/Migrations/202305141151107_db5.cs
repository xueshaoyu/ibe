namespace IBE.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExchangeFileDatas", "IsDowload", c => c.Boolean(nullable: false));
            DropColumn("dbo.ExchangeFileDatas", "IsRead");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ExchangeFileDatas", "IsRead", c => c.Boolean(nullable: false));
            DropColumn("dbo.ExchangeFileDatas", "IsDowload");
        }
    }
}
