namespace Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Students");
            AddColumn("dbo.Students", "StundentID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Students", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Codigo", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Students", "StundentID");
            DropColumn("dbo.Students", "studentID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "studentID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Students");
            AlterColumn("dbo.Students", "Codigo", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "LastName", c => c.String());
            DropColumn("dbo.Students", "StundentID");
            AddPrimaryKey("dbo.Students", "studentID");
        }
    }
}
