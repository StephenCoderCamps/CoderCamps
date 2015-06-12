namespace PhotoAlbum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Images", "ImageURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Images", "ImageURL");
        }
    }
}
