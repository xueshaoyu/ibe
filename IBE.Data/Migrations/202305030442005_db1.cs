namespace IBE.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.Teachers", "Role_Id", "dbo.Roles");
            DropIndex("dbo.Students", new[] { "Role_Id" });
            DropIndex("dbo.Teachers", new[] { "Role_Id" });
            AddColumn("dbo.ExchangeFileDatas", "Name", c => c.String());
            AddColumn("dbo.ExchangeFileDatas", "Time", c => c.DateTime(nullable: false));
            AddColumn("dbo.ExchangeFileDatas", "IsRead", c => c.Boolean(nullable: false));
            DropColumn("dbo.Students", "Role_Id");
            DropColumn("dbo.Teachers", "Role_Id");
            DropTable("dbo.Roles");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Remark = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Teachers", "Role_Id", c => c.Int());
            AddColumn("dbo.Students", "Role_Id", c => c.Int());
            DropColumn("dbo.ExchangeFileDatas", "IsRead");
            DropColumn("dbo.ExchangeFileDatas", "Time");
            DropColumn("dbo.ExchangeFileDatas", "Name");
            CreateIndex("dbo.Teachers", "Role_Id");
            CreateIndex("dbo.Students", "Role_Id");
            AddForeignKey("dbo.Teachers", "Role_Id", "dbo.Roles", "Id");
            AddForeignKey("dbo.Students", "Role_Id", "dbo.Roles", "Id");
        }
    }
}
