namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDependentTask : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.TaskItems", "DependentTaskId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TaskItems", "DependentTaskId");
        }
    }
}
