namespace EFCodesFirstTekrar_0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branslar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Isim = c.String(),
                        YaratılmaTarihi = c.DateTime(name: "Yaratılma Tarihi", nullable: false),
                        GuncellemeTarihi = c.DateTime(name: "Guncelleme Tarihi"),
                        SilmeTarihi = c.DateTime(name: "Silme Tarihi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EgitmenBranslari",
                c => new
                    {
                        EgitmenID = c.Int(nullable: false),
                        BransID = c.Int(nullable: false),
                        YaratılmaTarihi = c.DateTime(name: "Yaratılma Tarihi", nullable: false),
                        GuncellemeTarihi = c.DateTime(name: "Guncelleme Tarihi"),
                        SilmeTarihi = c.DateTime(name: "Silme Tarihi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => new { t.EgitmenID, t.BransID })
                .ForeignKey("dbo.Branslar", t => t.BransID, cascadeDelete: true)
                .ForeignKey("dbo.Egitmenler", t => t.EgitmenID, cascadeDelete: true)
                .Index(t => t.EgitmenID)
                .Index(t => t.BransID);
            
            CreateTable(
                "dbo.Egitmenler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Isim = c.String(),
                        SoyIsim = c.String(),
                        YaratılmaTarihi = c.DateTime(name: "Yaratılma Tarihi", nullable: false),
                        GuncellemeTarihi = c.DateTime(name: "Guncelleme Tarihi"),
                        SilmeTarihi = c.DateTime(name: "Silme Tarihi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Dersler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MufredatAciklamasi = c.String(),
                        EgitmenID = c.Int(),
                        LabID = c.Int(),
                        YaratılmaTarihi = c.DateTime(name: "Yaratılma Tarihi", nullable: false),
                        GuncellemeTarihi = c.DateTime(name: "Guncelleme Tarihi"),
                        SilmeTarihi = c.DateTime(name: "Silme Tarihi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Egitmenler", t => t.EgitmenID)
                .ForeignKey("dbo.Lablar", t => t.LabID)
                .Index(t => t.EgitmenID)
                .Index(t => t.LabID);
            
            CreateTable(
                "dbo.Lablar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        No = c.String(),
                        Kat = c.String(),
                        YaratılmaTarihi = c.DateTime(name: "Yaratılma Tarihi", nullable: false),
                        GuncellemeTarihi = c.DateTime(name: "Guncelleme Tarihi"),
                        SilmeTarihi = c.DateTime(name: "Silme Tarihi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OgrenciDersleri",
                c => new
                    {
                        OgrenciID = c.Int(nullable: false),
                        DersID = c.Int(nullable: false),
                        YaratılmaTarihi = c.DateTime(name: "Yaratılma Tarihi", nullable: false),
                        GuncellemeTarihi = c.DateTime(name: "Guncelleme Tarihi"),
                        SilmeTarihi = c.DateTime(name: "Silme Tarihi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => new { t.OgrenciID, t.DersID })
                .ForeignKey("dbo.Dersler", t => t.DersID, cascadeDelete: true)
                .ForeignKey("dbo.Ogrenciler", t => t.OgrenciID, cascadeDelete: true)
                .Index(t => t.OgrenciID)
                .Index(t => t.DersID);
            
            CreateTable(
                "dbo.Ogrenciler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DanismanID = c.Int(),
                        Isim = c.String(),
                        SoyIsim = c.String(),
                        YaratılmaTarihi = c.DateTime(name: "Yaratılma Tarihi", nullable: false),
                        GuncellemeTarihi = c.DateTime(name: "Guncelleme Tarihi"),
                        SilmeTarihi = c.DateTime(name: "Silme Tarihi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Danismanlar", t => t.DanismanID)
                .Index(t => t.DanismanID);
            
            CreateTable(
                "dbo.Danismanlar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Isim = c.String(),
                        SoyIsim = c.String(),
                        YaratılmaTarihi = c.DateTime(name: "Yaratılma Tarihi", nullable: false),
                        GuncellemeTarihi = c.DateTime(name: "Guncelleme Tarihi"),
                        SilmeTarihi = c.DateTime(name: "Silme Tarihi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EgitmenBranslari", "EgitmenID", "dbo.Egitmenler");
            DropForeignKey("dbo.OgrenciDersleri", "OgrenciID", "dbo.Ogrenciler");
            DropForeignKey("dbo.Ogrenciler", "DanismanID", "dbo.Danismanlar");
            DropForeignKey("dbo.OgrenciDersleri", "DersID", "dbo.Dersler");
            DropForeignKey("dbo.Dersler", "LabID", "dbo.Lablar");
            DropForeignKey("dbo.Dersler", "EgitmenID", "dbo.Egitmenler");
            DropForeignKey("dbo.EgitmenBranslari", "BransID", "dbo.Branslar");
            DropIndex("dbo.Ogrenciler", new[] { "DanismanID" });
            DropIndex("dbo.OgrenciDersleri", new[] { "DersID" });
            DropIndex("dbo.OgrenciDersleri", new[] { "OgrenciID" });
            DropIndex("dbo.Dersler", new[] { "LabID" });
            DropIndex("dbo.Dersler", new[] { "EgitmenID" });
            DropIndex("dbo.EgitmenBranslari", new[] { "BransID" });
            DropIndex("dbo.EgitmenBranslari", new[] { "EgitmenID" });
            DropTable("dbo.Danismanlar");
            DropTable("dbo.Ogrenciler");
            DropTable("dbo.OgrenciDersleri");
            DropTable("dbo.Lablar");
            DropTable("dbo.Dersler");
            DropTable("dbo.Egitmenler");
            DropTable("dbo.EgitmenBranslari");
            DropTable("dbo.Branslar");
        }
    }
}
