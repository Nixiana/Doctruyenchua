namespace Doctruyenchua.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTableStatistic : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Truyens", "User_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Truyens", "TenTruyen", c => c.String());
            CreateIndex("dbo.Truyens", "User_Id");
            AddForeignKey("dbo.Truyens", "User_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Truyens", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Truyens", new[] { "User_Id" });
            AlterColumn("dbo.Truyens", "TenTruyen", c => c.String(nullable: false));
            DropColumn("dbo.Truyens", "User_Id");
        }
    }
}
