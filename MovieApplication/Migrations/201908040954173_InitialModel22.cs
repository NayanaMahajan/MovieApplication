namespace MovieApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel22 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.PaymentModes");
            AddColumn("dbo.PaymentModes", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.PaymentModes", "PaymentType", c => c.String());
            AddPrimaryKey("dbo.PaymentModes", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.PaymentModes");
            AlterColumn("dbo.PaymentModes", "PaymentType", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.PaymentModes", "Id");
            AddPrimaryKey("dbo.PaymentModes", "PaymentType");
        }
    }
}
