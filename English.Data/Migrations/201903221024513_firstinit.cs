namespace English.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstinit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        Name = c.String(nullable: false, maxLength: 50),
                        STT = c.Int(),
                        Search = c.String(nullable: false, maxLength: 256),
                        Notice = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Lessons",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        Name = c.String(nullable: false, maxLength: 50),
                        STT = c.Int(),
                        Search = c.String(nullable: false, maxLength: 256),
                        Notice = c.String(nullable: false, maxLength: 256),
                        Url_Image = c.String(nullable: false, maxLength: 50),
                        Url_Video = c.String(nullable: false, maxLength: 50),
                        Id_Text = c.String(nullable: false, maxLength: 50),
                        Id_Course = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Courses", t => t.Id_Course, cascadeDelete: true)
                .Index(t => t.Id_Course);
            
            CreateTable(
                "dbo.ResultLessons",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        Id_User = c.String(nullable: false, maxLength: 50),
                        Id_Lesson = c.String(nullable: false, maxLength: 50),
                        STT = c.Int(),
                        Math = c.Int(nullable: false),
                        Search = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Texts",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        Question_A = c.String(nullable: false, maxLength: 50),
                        Question_B = c.String(nullable: false, maxLength: 50),
                        Question_C = c.String(nullable: false, maxLength: 50),
                        Question_D = c.String(nullable: false, maxLength: 50),
                        STT = c.Int(),
                        Notice = c.String(nullable: false, maxLength: 256),
                        Result = c.String(nullable: false, maxLength: 50),
                        Id_Lesson = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Lessons", t => t.Id_Lesson, cascadeDelete: true)
                .Index(t => t.Id_Lesson);
            
            CreateTable(
                "dbo.IdentityUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId });
            
            CreateTable(
                "dbo.IdentityUserLogins",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Texts", "Id_Lesson", "dbo.Lessons");
            DropForeignKey("dbo.Lessons", "Id_Course", "dbo.Courses");
            DropIndex("dbo.Texts", new[] { "Id_Lesson" });
            DropIndex("dbo.Lessons", new[] { "Id_Course" });
            DropTable("dbo.IdentityUserLogins");
            DropTable("dbo.IdentityUserRoles");
            DropTable("dbo.Texts");
            DropTable("dbo.ResultLessons");
            DropTable("dbo.Lessons");
            DropTable("dbo.Courses");
        }
    }
}
