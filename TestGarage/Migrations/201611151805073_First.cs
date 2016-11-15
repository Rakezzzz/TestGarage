namespace TestGarage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Parkingspots",
                c => new
                    {
                        ParkId = c.Int(nullable: false, identity: true),
                        ParkedVehicle_RegNum = c.String(maxLength: 128),
                        Renter_SSN = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ParkId)
                .ForeignKey("dbo.Vehicles", t => t.ParkedVehicle_RegNum)
                .ForeignKey("dbo.People", t => t.Renter_SSN)
                .Index(t => t.ParkedVehicle_RegNum)
                .Index(t => t.Renter_SSN);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        RegNum = c.String(nullable: false, maxLength: 128),
                        Owner_SSN = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.RegNum)
                .ForeignKey("dbo.People", t => t.Owner_SSN)
                .Index(t => t.Owner_SSN);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        SSN = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SSN);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UserName = c.String(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        User_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.LoginProvider, t.ProviderKey })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserClaims", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Parkingspots", "Renter_SSN", "dbo.People");
            DropForeignKey("dbo.Parkingspots", "ParkedVehicle_RegNum", "dbo.Vehicles");
            DropForeignKey("dbo.Vehicles", "Owner_SSN", "dbo.People");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "User_Id" });
            DropIndex("dbo.Vehicles", new[] { "Owner_SSN" });
            DropIndex("dbo.Parkingspots", new[] { "Renter_SSN" });
            DropIndex("dbo.Parkingspots", new[] { "ParkedVehicle_RegNum" });
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.People");
            DropTable("dbo.Vehicles");
            DropTable("dbo.Parkingspots");
        }
    }
}
