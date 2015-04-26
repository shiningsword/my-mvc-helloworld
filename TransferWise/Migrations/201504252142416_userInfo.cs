namespace TransferWise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserInfoes",
                c => new
                    {
                        UserInfoId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        userID = c.String(),
                    })
                .PrimaryKey(t => t.UserInfoId);
            
            AddColumn("dbo.AspNetUsers", "userInfo_UserInfoId", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "userInfo_UserInfoId");
            AddForeignKey("dbo.AspNetUsers", "userInfo_UserInfoId", "dbo.UserInfoes", "UserInfoId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "userInfo_UserInfoId", "dbo.UserInfoes");
            DropIndex("dbo.AspNetUsers", new[] { "userInfo_UserInfoId" });
            DropColumn("dbo.AspNetUsers", "userInfo_UserInfoId");
            DropTable("dbo.UserInfoes");
        }
    }
}
