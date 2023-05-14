namespace IBE.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExchangeFileDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sender = c.String(),
                        DestEmail = c.String(),
                        FileName = c.String(),
                        EncryptFilePath = c.String(),
                        Time = c.DateTime(nullable: false),
                        KeyX = c.String(),
                        KeyY = c.String(),
                        IsRead = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LoginAccount = c.String(),
                        Password = c.String(),
                        AllowDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SecretKeys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        FileKey = c.String(),
                        EncryptFileKey = c.Int(nullable: false),
                        IBEMainKey = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LoginAccount = c.String(nullable: false),
                        Password = c.String(),
                        Email = c.String(nullable: false),
                        FirstQuestion = c.String(),
                        SecondQuestion = c.String(),
                        ThirdQuestion = c.String(),
                        FirstAnswer = c.String(),
                        SecondAnswer = c.String(),
                        ThirdAnswer = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.SecretKeys");
            DropTable("dbo.Managers");
            DropTable("dbo.ExchangeFileDatas");
        }
    }
}
