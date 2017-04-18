namespace AquariumEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AquaticLife", "DataAddedToTank", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AquaticLife", "DataAddedToTank", c => c.DateTime(nullable: false));
        }
    }
}
