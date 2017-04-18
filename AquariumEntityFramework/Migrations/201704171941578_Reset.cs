namespace AquariumEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Reset : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AquaticLifeAquarium",
                c => new
                    {
                        AquaticLife_Id = c.Int(nullable: false),
                        Aquarium_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AquaticLife_Id, t.Aquarium_Id })
                .ForeignKey("dbo.AquaticLife", t => t.AquaticLife_Id, cascadeDelete: true)
                .ForeignKey("dbo.Aquarium", t => t.Aquarium_Id, cascadeDelete: true)
                .Index(t => t.AquaticLife_Id)
                .Index(t => t.Aquarium_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AquaticLifeAquarium", "Aquarium_Id", "dbo.Aquarium");
            DropForeignKey("dbo.AquaticLifeAquarium", "AquaticLife_Id", "dbo.AquaticLife");
            DropIndex("dbo.AquaticLifeAquarium", new[] { "Aquarium_Id" });
            DropIndex("dbo.AquaticLifeAquarium", new[] { "AquaticLife_Id" });
            DropTable("dbo.AquaticLifeAquarium");
        }
    }
}
