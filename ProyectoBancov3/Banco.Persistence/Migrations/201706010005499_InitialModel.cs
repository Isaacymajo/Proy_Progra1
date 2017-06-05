namespace Banco.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Apellido = c.String(nullable: false),
                        Direccion = c.String(),
                        Correo = c.String(nullable: false),
                        Telefono = c.String(nullable: false),
                        Ruc = c.Int(),
                        RazonSocial = c.String(),
                        DNI = c.Int(),
                        Ocupacion = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Tarjetas",
                c => new
                    {
                        TarjetaId = c.Int(nullable: false, identity: true),
                        CodSeguridad = c.Long(nullable: false),
                        Contraseña = c.String(),
                        Debito = c.Long(nullable: false),
                        Credito = c.Long(nullable: false),
                        Moneda = c.String(),
                        clienteid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TarjetaId)
                .ForeignKey("dbo.Clientes", t => t.clienteid, cascadeDelete: true)
                .Index(t => t.clienteid);
            
            CreateTable(
                "dbo.Transacciones",
                c => new
                    {
                        TransaccionId = c.Int(nullable: false, identity: true),
                        CodigoSeguimiento = c.Long(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        TarjetaId = c.Int(nullable: false),
                        Tasa = c.Double(),
                        TipoTarjeta = c.String(),
                        Saldo = c.Long(),
                        FechaEntrega = c.DateTime(),
                        NumeroCuenta = c.Long(),
                        SaldoDisponible = c.Decimal(precision: 18, scale: 2),
                        SaldoTotal = c.Decimal(precision: 18, scale: 2),
                        TipoCuentaId = c.Int(),
                        CuentaDestino = c.Long(),
                        Monto = c.Decimal(precision: 18, scale: 2),
                        InformacionCuenta = c.String(),
                        DetalleSaldo = c.String(),
                        Deuda = c.Decimal(precision: 18, scale: 2),
                        CuentaCargo = c.Long(),
                        Empresa = c.String(),
                        Operador = c.String(),
                        MontoRecarga = c.Decimal(precision: 18, scale: 2),
                        NumeroMovil = c.Long(),
                        MontoTransferir = c.Decimal(precision: 18, scale: 2),
                        CodSeguridad = c.Long(),
                        CodCuentaInterbancaria = c.Int(),
                        RUC = c.Long(),
                        RazonSocial = c.String(),
                        CuentaPropia = c.String(),
                        DNI = c.Long(),
                        CuentaTerceros = c.Long(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.TransaccionId)
                .ForeignKey("dbo.TipoCuentas", t => t.TipoCuentaId, cascadeDelete: true)
                .ForeignKey("dbo.Tarjetas", t => t.TarjetaId, cascadeDelete: true)
                .Index(t => t.TarjetaId)
                .Index(t => t.TipoCuentaId);
            
            CreateTable(
                "dbo.TipoCuentas",
                c => new
                    {
                        TipoCuentaId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.TipoCuentaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tarjetas", "clienteid", "dbo.Clientes");
            DropForeignKey("dbo.Transacciones", "TarjetaId", "dbo.Tarjetas");
            DropForeignKey("dbo.Transacciones", "TipoCuentaId", "dbo.TipoCuentas");
            DropIndex("dbo.Transacciones", new[] { "TipoCuentaId" });
            DropIndex("dbo.Transacciones", new[] { "TarjetaId" });
            DropIndex("dbo.Tarjetas", new[] { "clienteid" });
            DropTable("dbo.TipoCuentas");
            DropTable("dbo.Transacciones");
            DropTable("dbo.Tarjetas");
            DropTable("dbo.Clientes");
        }
    }
}
