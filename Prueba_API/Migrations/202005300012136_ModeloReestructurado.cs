namespace Prueba_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModeloReestructurado : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Autoes", "Nombre", c => c.String(nullable: false));
            AlterColumn("dbo.Autoes", "Modelo", c => c.String(nullable: false));
            AlterColumn("dbo.Autoes", "Imagen", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Autoes", "Imagen", c => c.String());
            AlterColumn("dbo.Autoes", "Modelo", c => c.String());
            AlterColumn("dbo.Autoes", "Nombre", c => c.String());
        }
    }
}
