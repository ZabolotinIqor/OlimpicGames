namespace OlimpicGames.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        countryName = c.String(),
                        city = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        playerName = c.String(),
                        playerSurname = c.String(),
                        playerFathersName = c.String(),
                        birthDate = c.DateTime(nullable: false),
                        playerPhotoUrl = c.String(),
                        country_Id = c.Int(),
                        sport_Id = c.Int(),
                        team_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.country_Id)
                .ForeignKey("dbo.SportTypes", t => t.sport_Id)
                .ForeignKey("dbo.Teams", t => t.team_Id)
                .Index(t => t.country_Id)
                .Index(t => t.sport_Id)
                .Index(t => t.team_Id);
            
            CreateTable(
                "dbo.Results",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        result = c.Int(nullable: false),
                        player_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.player_Id)
                .Index(t => t.player_Id);
            
            CreateTable(
                "dbo.SportTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        sportName = c.String(),
                        olimpicGame_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OlimpicGames", t => t.olimpicGame_Id)
                .Index(t => t.olimpicGame_Id);
            
            CreateTable(
                "dbo.OlimpicGames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        dateOfOlimpicGame = c.DateTime(nullable: false),
                        olimpicType = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        teamName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "team_Id", "dbo.Teams");
            DropForeignKey("dbo.Players", "sport_Id", "dbo.SportTypes");
            DropForeignKey("dbo.SportTypes", "olimpicGame_Id", "dbo.OlimpicGames");
            DropForeignKey("dbo.Results", "player_Id", "dbo.Players");
            DropForeignKey("dbo.Players", "country_Id", "dbo.Countries");
            DropIndex("dbo.SportTypes", new[] { "olimpicGame_Id" });
            DropIndex("dbo.Results", new[] { "player_Id" });
            DropIndex("dbo.Players", new[] { "team_Id" });
            DropIndex("dbo.Players", new[] { "sport_Id" });
            DropIndex("dbo.Players", new[] { "country_Id" });
            DropTable("dbo.Teams");
            DropTable("dbo.OlimpicGames");
            DropTable("dbo.SportTypes");
            DropTable("dbo.Results");
            DropTable("dbo.Players");
            DropTable("dbo.Countries");
        }
    }
}
