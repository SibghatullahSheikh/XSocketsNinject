using Ninject.Modules;
using XSocketsNinject.Core.Interfaces.Data;
using XSocketsNinject.Core.Interfaces.Service;
using XSocketsNinject.Data;
using XSocketsNinject.Service;

namespace XSocketsNinject.XControllers
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            //Setup Ninject bindings...
            Bind<IUnitOfWork>().To<UnitOfWork>().InThreadScope();
            Bind<IDatabaseFactory>().To<DatabaseFactory>().InThreadScope();
            Bind<IPersonRepository>().To<PersonRepository>().InThreadScope();
            Bind<IPersonService>().To<PersonService>().InThreadScope();
        }
    }
}