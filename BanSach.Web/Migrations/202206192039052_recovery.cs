﻿namespace BanSach.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class recovery : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetRoles", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetRoles", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
    }
}
