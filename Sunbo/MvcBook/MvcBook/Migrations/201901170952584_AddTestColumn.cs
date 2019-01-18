namespace MvcBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTestColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Test", c => c.String(maxLength:50));

            CreateTable(
                "dbo.Authors",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(maxLength: 200),
                })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
        }
    }
}
