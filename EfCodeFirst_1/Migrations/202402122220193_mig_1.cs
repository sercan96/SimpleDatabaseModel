namespace EfCodeFirst_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Surname = c.String(),
                        Country = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Name = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                        DeletedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BookAuthors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BookID = c.Int(nullable: false),
                        AuthorID = c.Int(nullable: false),
                        Name = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                        DeletedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Authors", t => t.AuthorID, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.BookID, cascadeDelete: true)
                .Index(t => t.BookID)
                .Index(t => t.AuthorID);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PageCount = c.Int(nullable: false),
                        Publisher = c.String(),
                        PublicationDate = c.DateTime(nullable: false),
                        Name = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                        DeletedDate = c.DateTime(),
                        Category_ID = c.Int(),
                        Shelf_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.Category_ID)
                .ForeignKey("dbo.Shelves", t => t.Shelf_ID)
                .Index(t => t.Category_ID)
                .Index(t => t.Shelf_ID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Name = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                        DeletedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Shelves",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Location = c.String(),
                        ShelfType = c.String(),
                        Capacity = c.Int(nullable: false),
                        Name = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                        DeletedDate = c.DateTime(),
                        Room_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Rooms", t => t.Room_ID)
                .Index(t => t.Room_ID);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Floor = c.Int(nullable: false),
                        Area = c.Double(nullable: false),
                        Name = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                        DeletedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shelves", "Room_ID", "dbo.Rooms");
            DropForeignKey("dbo.Books", "Shelf_ID", "dbo.Shelves");
            DropForeignKey("dbo.Books", "Category_ID", "dbo.Categories");
            DropForeignKey("dbo.BookAuthors", "BookID", "dbo.Books");
            DropForeignKey("dbo.BookAuthors", "AuthorID", "dbo.Authors");
            DropIndex("dbo.Shelves", new[] { "Room_ID" });
            DropIndex("dbo.Books", new[] { "Shelf_ID" });
            DropIndex("dbo.Books", new[] { "Category_ID" });
            DropIndex("dbo.BookAuthors", new[] { "AuthorID" });
            DropIndex("dbo.BookAuthors", new[] { "BookID" });
            DropTable("dbo.Rooms");
            DropTable("dbo.Shelves");
            DropTable("dbo.Categories");
            DropTable("dbo.Books");
            DropTable("dbo.BookAuthors");
            DropTable("dbo.Authors");
        }
    }
}
