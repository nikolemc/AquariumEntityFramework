namespace AquariumEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AquaticLife",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Color = c.String(),
                        AquaticLifeName = c.String(),
                        DataAddedToTank = c.DateTime(),
                        IsInQuarantine = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ocean",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OceanName = c.String(),
                        AverageTemp = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ocean");
            DropTable("dbo.AquaticLife");
        }
    }
}
