[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Banco.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Banco.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace Banco.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Banco.Entities.IRepositories;
    using Banco.Persistence.Repositories;
    using Banco.Persistence;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IUnityOfWork>().To<UnityOfWork>();
            kernel.Bind<BancoDbContext>().To<BancoDbContext>();

            kernel.Bind<IAperturaRepository>().To<AperturaRepository>();
            kernel.Bind<IClienteRepository>().To<ClienteRepository>();
            kernel.Bind<ICuentaRepository>().To<CuentaRepository>();
            kernel.Bind<IDepositoRepository>().To<DepositoRepository>();
            kernel.Bind<IInterbancariaRepository>().To<InterbancariaRepository>();
            kernel.Bind<IMovimientosRepository>().To<MovimientosRepository>();
            kernel.Bind<IPagoServiciosRepository>().To<PagoServiciosRepository>();
            kernel.Bind<IPJuridicaRepository>().To<PJuridicaRepository>();
            kernel.Bind<IPNaturalRepository>().To<PNaturalRepository>();
            kernel.Bind<IPropiaRepository>().To<PropiaRepository>();
            kernel.Bind<IRecargasMovilesRepository>().To<RecargasMovilesRepository>();
            kernel.Bind<ITarjetaRepository>().To<TarjetaRepository>();
            kernel.Bind<ITercerosRepository>().To<TercerosRepository>();
            kernel.Bind<ITipoCuentaRepository>().To<TipoCuentaRepository>();
            kernel.Bind<ITransaccionRepository>().To<TransaccionRepository>();
            kernel.Bind<ITransferenciasRepository>().To<TransferenciasRepository>();
        }        
    }
}
