namespace IBE.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExchangeFileDatas", "Sender", c => c.String());
            AddColumn("dbo.ExchangeFileDatas", "FileName", c => c.String());
            DropColumn("dbo.ExchangeFileDatas", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ExchangeFileDatas", "Name", c => c.String());
            DropColumn("dbo.ExchangeFileDatas", "FileName");
            DropColumn("dbo.ExchangeFileDatas", "Sender");
        }
    }
}
