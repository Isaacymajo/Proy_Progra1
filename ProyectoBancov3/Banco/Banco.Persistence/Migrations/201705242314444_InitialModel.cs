namespace Banco.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transaccions",
                c => new
                    {
                        TransaccionId = c.Int(nullable: false, identity: true),
                        CodigoSeguimiento = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        AperturaId = c.Int(),
                        Tasa = c.Double(),
                        TipoTarjeta = c.String(),
                        saldo = c.Int(),
                        FechaEntrega = c.DateTime(),
                        CuentaId = c.Int(),
                        TipoCuenta = c.Int(),
                        NumeroCuenta = c.Int(),
                        SaldoDisponible = c.Decimal(precision: 18, scale: 2),
                        SaldoTotal = c.Decimal(precision: 18, scale: 2),
                        DepositoId = c.Int(),
                        CuentaDestino = c.Int(),
                        Monto = c.Decimal(precision: 18, scale: 2),
                        TransferenciaId = c.Int(),
                        MontoTransferir = c.Double(),
                        CodSeguridad = c.Int(),
                        InterbancariaId = c.Int(),
                        CodCuentaInterbancaria = c.Int(),
                        RUC = c.Int(),
                        RazonSocial = c.String(),
                        MovimientoId = c.Int(),
                        InformacionCuenta = c.String(),
                        DetalleSaldo = c.String(),
                        PropiaId = c.Int(),
                        CuentaPropia = c.String(),
                        DNI = c.Int(),
                        RecargasMobilesId = c.Int(),
                        Operador = c.String(),
                        MontoRecarga = c.Double(),
                        NumeroMobil = c.Int(),
                        TercerosId = c.Int(),
                        CuentaTerceros = c.Int(),
                        codServicio = c.Int(),
                        deuda = c.Decimal(precision: 18, scale: 2),
                        cuentaCargo = c.Int(),
                        empresa = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.TransaccionId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Telefono = c.Int(nullable: false),
                        PJuridicaId = c.Int(),
                        Ruc = c.Int(),
                        RazonSocial = c.String(),
                        PNaturalId = c.Int(),
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
                        CodSeguridad = c.Int(nullable: false),
                        Debito = c.Int(nullable: false),
                        Credito = c.Int(nullable: false),
                        Moneda = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.TarjetaId);
            
            CreateTable(
                "dbo.TipoCuentas",
                c => new
                    {
                        TipoCuentaId = c.Int(nullable: false, identity: true),
                        descripcion = c.String(),
                    })
                .PrimaryKey(t => t.TipoCuentaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TipoCuentas");
            DropTable("dbo.Tarjetas");
            DropTable("dbo.Clientes");
            DropTable("dbo.Transaccions");
        }
    }
}
