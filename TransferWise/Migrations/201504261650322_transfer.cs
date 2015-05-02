namespace TransferWise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class transfer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transfers",
                c => new
                    {
                        TransferID = c.Int(nullable: false, identity: true),
                        RecipientUserName = c.String(),
                        SenderAccountName = c.String(),
                        SenderAccountIndex = c.Int(nullable: false),
                        Message = c.String(),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TransferID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Transfers");
        }
    }
}
