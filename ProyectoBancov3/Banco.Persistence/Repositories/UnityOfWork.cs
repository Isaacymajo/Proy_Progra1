using Banco.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Persistence.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {

        private readonly BancoDbContext _Context;

        public IAperturaRepository Aperturas { get; private set; }
        public IClienteRepository Clientes { get; private set; }
        public ICuentaRepository Cuentas { get; private set; }
        public IDepositoRepository Depositos { get; private set; }
        public IInterbancariaRepository Interbancarias { get; private set; }
        public IMovimientosRepository Movimientoss { get; private set; }
        public IPagoServiciosRepository PagoServicioss { get; private set; }
        public IPJuridicaRepository Pjuridicas { get; private set; }
        public IPNaturalRepository PNaturals { get; private set; }
        public IPropiaRepository Propias { get; private set; }
        public IRecargasMovilesRepository RecargasMoviless { get; private set; }
        public ITarjetaRepository Tarjetas { get; private set; }
        public ITercerosRepository Terceross { get; private set; }
        public ITipoCuentaRepository TipoCuentas { get; private set; }
        public ITransaccionRepository Transaccions { get; private set; }
        public ITransferenciasRepository Transferenciass { get; private set; }

        public UnityOfWork(BancoDbContext context)
        {
            _Context = context;

            Aperturas = new AperturaRepository(_Context);
            Clientes = new ClienteRepository(_Context);
            Cuentas = new CuentaRepository(_Context);
            Depositos = new DepositoRepository(_Context);
            Interbancarias = new InterbancariaRepository(_Context);
            Movimientoss = new MovimientosRepository(_Context);
            PagoServicioss = new PagoServiciosRepository(_Context);
            Pjuridicas = new PJuridicaRepository(_Context);
            PNaturals = new PNaturalRepository(_Context);
            Propias = new PropiaRepository(_Context);
            RecargasMoviless = new RecargasMovilesRepository(_Context);
            Tarjetas = new TarjetaRepository(_Context);
            Terceross = new TercerosRepository(_Context);
            TipoCuentas = new TipoCuentaRepository(_Context);
            Transaccions = new TransaccionRepository(_Context);
            Transferenciass = new TransferenciasRepository(_Context);

        }

        public UnityOfWork()
        {

        }

        public void Dispose()
        {
            _Context.Dispose();
        }

        public int SaveChanges()
        {
            return _Context.SaveChanges();
        }

        public void StateModified(object entity)
        {
            _Context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
