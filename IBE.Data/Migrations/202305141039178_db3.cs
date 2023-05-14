namespace IBE.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ExchangeFileDatas", "KeyX");
            DropColumn("dbo.ExchangeFileDatas", "KeyY");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ExchangeFileDatas", "KeyY", c => c.String());
            AddColumn("dbo.ExchangeFileDatas", "KeyX", c => c.String());
        }
    }
}
