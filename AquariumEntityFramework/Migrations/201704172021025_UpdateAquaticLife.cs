namespace AquariumEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAquaticLife : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AquaticLife", "DateAddedToTank", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AquaticLife", "DataAddedToTank", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AquaticLife", "DataAddedToTank", c => c.DateTime());
            DropColumn("dbo.AquaticLife", "DateAddedToTank");
        }
    }
}
