namespace Doctruyenchua.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableTruyen : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chuong_hinhanh",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tenhinhanh = c.String(),
                        Chuong_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Chuongs", t => t.Chuong_Id)
                .Index(t => t.Chuong_Id);
            
            CreateTable(
                "dbo.Chuongs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SoChuong = c.Int(nullable: false),
                        TenChuong = c.String(nullable: false),
                        NoiDungChuong = c.String(nullable: false),
                        Truyen_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Truyens", t => t.Truyen_Id)
                .Index(t => t.Truyen_Id);
            
            CreateTable(
                "dbo.Truyens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenTruyen = c.String(nullable: false),
                        AnhBia = c.String(),
                        TacGia = c.String(nullable: false),
                        MoTaNgan = c.String(maxLength: 255),
                        DateTime = c.DateTime(nullable: false),
                        TheLoai_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TheLoais", t => t.TheLoai_Id, cascadeDelete: true)
                .Index(t => t.TheLoai_Id);
            
            CreateTable(
                "dbo.TheLoais",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenTheLoai = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Chuong_hinhanh", "Chuong_Id", "dbo.Chuongs");
            DropForeignKey("dbo.Chuongs", "Truyen_Id", "dbo.Truyens");
            DropForeignKey("dbo.Truyens", "TheLoai_Id", "dbo.TheLoais");
            DropIndex("dbo.Truyens", new[] { "TheLoai_Id" });
            DropIndex("dbo.Chuongs", new[] { "Truyen_Id" });
            DropIndex("dbo.Chuong_hinhanh", new[] { "Chuong_Id" });
            DropTable("dbo.TheLoais");
            DropTable("dbo.Truyens");
            DropTable("dbo.Chuongs");
            DropTable("dbo.Chuong_hinhanh");
        }
    }
}
