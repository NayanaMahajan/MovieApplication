namespace MovieApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PaymentModes",
                c => new
                    {
                    Id = c.Int(nullable: false, identity: true),
                    PaymentType = c.String(),
                    })
                .PrimaryKey(t => t.PaymentType);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PaymentModes");
        }
    }
}
