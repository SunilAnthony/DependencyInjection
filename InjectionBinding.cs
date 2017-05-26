using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

namespace DependencyInjection
{
    public class InjectionBinding : NinjectModule
    {
        public override void Load()
        {
            //Bind<IOrderSaver>().To<LoggingOrderDB>();
            Bind<IOrderSaver>().To<OrderDatabase>();
            //Bind<IOrderSaver>().To<XmlOrderSaver>();
        }
    }
}
