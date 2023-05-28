namespace IBE.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExchangeFileDatas", "AesSourceKey", c => c.String());
            AddColumn("dbo.ExchangeFileDatas", "AesEncryptKey", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ExchangeFileDatas", "AesEncryptKey");
            DropColumn("dbo.ExchangeFileDatas", "AesSourceKey");
        }
    }
}
