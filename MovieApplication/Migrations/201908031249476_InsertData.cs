namespace MovieApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertData : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT CUSTOMERS ON");
            Sql("INSERT INTO CUSTOMERS(Id,Name,City,MovieName)VALUES(1,'Nayana','Pune','KabirSingh')");
            Sql("INSERT INTO CUSTOMERS(Id,Name,City,MovieName)VALUES(2,'komal','Mumbai','Hum Sath Sath Hain')");
            Sql("INSERT INTO CUSTOMERS(Id,Name,City,MovieName)VALUES(3,'Hema','Dhule','Hum Apke Hain Koun')");
        }
        
        public override void Down()
        {
        }
    }
}
