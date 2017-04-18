namespace AquariumEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateForeignKeyOcean : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AquaticLife", "Ocean_Id", "dbo.Ocean");
            DropForeignKey("dbo.Ocean", "Aquarium_Id", "dbo.Aquarium");
            DropIndex("dbo.AquaticLife", new[] { "Ocean_Id" });
            DropIndex("dbo.Ocean", new[] { "Aquarium_Id" });
            CreateTable(
                "dbo.OceanAquaticLife",
                c => new
                    {
                        Ocean_Id = c.Int(nullable: false),
                        AquaticLife_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ocean_Id, t.AquaticLife_Id })
                .ForeignKey("dbo.Ocean", t => t.Ocean_Id, cascadeDelete: true)
                .ForeignKey("dbo.AquaticLife", t => t.AquaticLife_Id, cascadeDelete: true)
                .Index(t => t.Ocean_Id)
                .Index(t => t.AquaticLife_Id);
            
            DropColumn("dbo.AquaticLife", "Ocean_Id");
            DropColumn("dbo.Ocean", "Aquarium_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ocean", "Aquarium_Id", c => c.Int());
            AddColumn("dbo.AquaticLife", "Ocean_Id", c => c.Int());
            DropForeignKey("dbo.OceanAquaticLife", "AquaticLife_Id", "dbo.AquaticLife");
            DropForeignKey("dbo.OceanAquaticLife", "Ocean_Id", "dbo.Ocean");
            DropIndex("dbo.OceanAquaticLife", new[] { "AquaticLife_Id" });
            DropIndex("dbo.OceanAquaticLife", new[] { "Ocean_Id" });
            DropTable("dbo.OceanAquaticLife");
            CreateIndex("dbo.Ocean", "Aquarium_Id");
            CreateIndex("dbo.AquaticLife", "Ocean_Id");
            AddForeignKey("dbo.Ocean", "Aquarium_Id", "dbo.Aquarium", "Id");
            AddForeignKey("dbo.AquaticLife", "Ocean_Id", "dbo.Ocean", "Id");
        }
    }
}
