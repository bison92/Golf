using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractCrudRepository;
using GolfBackEnd.Repository;
using Microsoft.Practices.Unity.InterceptionExtension;
using Microsoft.Practices.Unity;
using GolfBackEnd.Model;

namespace GolfBackEnd
{
    public class UnityContainerFactory
    {
        public virtual IGolfDBFactory CreateDBFactory()
        {
            return new GolfDBFactory();
        }

        public virtual InterceptionBehavior CreateInterceptionBehavior()
        {
            return new InterceptionBehavior(new MiInterceptionBehavior());
        }
        public IUnityContainer GetInstance()
        {
            UnityContainer container = new UnityContainer();

            container.AddNewExtension<Interception>();
            
            Interceptor interceptor = new Interceptor(new InterfaceInterceptor());
            InterceptionBehavior interceptionBehavior = CreateInterceptionBehavior();
            
            container.RegisterType<IGolfDBFactory, GolfDBFactory>();

            container.RegisterType<IConversor<Reserva, ReservaDTO>, ReservaConversor>();

            container.RegisterType<IReservaRepository, ReservaRepository>(
                interceptor,
                interceptionBehavior);


            return container;
        }
    }
}
