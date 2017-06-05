using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities.IRepositories
{
    public interface IUnityOfWork : IDisposable
    {
        IAperturaRepository Aperturas { get; }
        IClienteRepository Clientes { get; }
        ICuentaRepository Cuentas { get; }
        IDepositoRepository Depositos { get; }
        IInterbancariaRepository Interbancarias { get; }
        IMovimientosRepository Movimientoss { get; }
        IPagoServiciosRepository PagoServicioss { get; }
        IPJuridicaRepository Pjuridicas { get; }
        IPNaturalRepository PNaturals { get; }
        IPropiaRepository Propias { get; }
        IRecargasMovilesRepository RecargasMoviless { get; }
        ITarjetaRepository Tarjetas { get; }
        ITercerosRepository Terceross { get; }
        ITipoCuentaRepository TipoCuentas { get; }
        ITransaccionRepository Transaccions { get; }
        ITransferenciasRepository Transferenciass { get; }
        
        //Metodo que guardara los cambios en la base de datos
        int SaveChanges();
         void StateModified(object entity);
    }
}
