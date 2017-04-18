namespace AquariumEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aquarium",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AquariumName = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Aquarium");
        }
    }
}
