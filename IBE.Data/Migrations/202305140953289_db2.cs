namespace IBE.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SecretKeys", "EncryptFileKey", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SecretKeys", "EncryptFileKey", c => c.Int(nullable: false));
        }
    }
}
