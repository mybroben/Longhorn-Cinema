namespace LonghornCinemaFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatesomething : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tickets", "Seat", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tickets", "Seat", c => c.String(nullable: false));
        }
    }
}