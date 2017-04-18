namespace AquariumEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAquaticLifeOceanTableLink : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AquaticLife", "Ocean_Id", c => c.Int());
            AddColumn("dbo.Ocean", "Aquarium_Id", c => c.Int());
            CreateIndex("dbo.AquaticLife", "Ocean_Id");
            CreateIndex("dbo.Ocean", "Aquarium_Id");
            AddForeignKey("dbo.AquaticLife", "Ocean_Id", "dbo.Ocean", "Id");
            AddForeignKey("dbo.Ocean", "Aquarium_Id", "dbo.Aquarium", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ocean", "Aquarium_Id", "dbo.Aquarium");
            DropForeignKey("dbo.AquaticLife", "Ocean_Id", "dbo.Ocean");
            DropIndex("dbo.Ocean", new[] { "Aquarium_Id" });
            DropIndex("dbo.AquaticLife", new[] { "Ocean_Id" });
            DropColumn("dbo.Ocean", "Aquarium_Id");
            DropColumn("dbo.AquaticLife", "Ocean_Id");
        }
    }
}
