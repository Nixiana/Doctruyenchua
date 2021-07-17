namespace Doctruyenchua.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO THELOAIS (TenTheLoai) VALUES ('Mạt Thế')");
            Sql("INSERT INTO THELOAIS (TenTheLoai) VALUES ('Hài Hước')");
            Sql("INSERT INTO THELOAIS (TenTheLoai) VALUES ('Trọng Sinh')");
            Sql("INSERT INTO THELOAIS (TenTheLoai) VALUES ('Lịch Sử')");
            Sql("INSERT INTO THELOAIS (TenTheLoai) VALUES ('Quân Sự')");
            Sql("INSERT INTO THELOAIS (TenTheLoai) VALUES ('Dị Giới')");
            Sql("INSERT INTO THELOAIS (TenTheLoai) VALUES ('Xuyên Không')");
        }
        
        public override void Down()
        {
        }
    }
}
