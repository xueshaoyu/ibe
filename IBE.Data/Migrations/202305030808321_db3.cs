namespace IBE.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExchangeFileDatas", "KeyX", c => c.String());
            AddColumn("dbo.ExchangeFileDatas", "KeyY", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ExchangeFileDatas", "KeyY");
            DropColumn("dbo.ExchangeFileDatas", "KeyX");
        }
    }
}
