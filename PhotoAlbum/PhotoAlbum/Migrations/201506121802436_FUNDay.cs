namespace PhotoAlbum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FUNDay : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AlbumName = c.String(),
                        AlbumOwner = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImageTitle = c.String(),
                        DateTaken = c.DateTime(nullable: false),
                        ImageOwner = c.String(),
                        ImageDescription = c.String(),
                        ImageRating = c.Int(nullable: false),
                        Album_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Albums", t => t.Album_Id)
                .Index(t => t.Album_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Images", "Album_Id", "dbo.Albums");
            DropIndex("dbo.Images", new[] { "Album_Id" });
            DropTable("dbo.Images");
            DropTable("dbo.Albums");
        }
    }
}
