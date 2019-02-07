using Castle.Core.Resource;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCFirst
{
    class Program
    {
        public interface IDriver
        {
            void GetDriver();
        }
        public class BusDriver : IDriver
        {
            public void GetDriver()
            {
                Console.WriteLine("Bus Driving.");
            }
        }
        public class CarDriver : IDriver
        {
            public void GetDriver()
            {
                Console.WriteLine("Car Driving.");
            }
        }
        public interface IPassenger
        {
            void GetTrip();
        }
        public class BusPassenger : IPassenger
        {
            public void GetTrip()
            {
                Console.WriteLine("Sightseeing by Bus.");
            }
        }
        public class CarPassenger : IPassenger
        {
            public void GetTrip()
            {
                Console.WriteLine("Sightseeing by Car.");
            }
        }
        public class TripManager
        {
            IPassenger passenger = null;
            IDriver driver = null;

            public TripManager(IPassenger _passenger, IDriver _driver)
            {
                this.passenger = _passenger;
                this.driver = _driver;
            }

            public void MakeTrip()
            {
                driver.GetDriver();
                passenger.GetTrip();
            }
        }
        static void Main(string[] args)
        {
            //TripManager tripManager = new TripManager(new BusPassenger(), new BusDriver());
            //tripManager.MakeTrip();

            //tripManager = new TripManager(new CarPassenger(), new CarDriver());
            //tripManager.MakeTrip();
            TripManager tripManager = new TripManager(IOCUtil.Resolve<IPassenger>(),IOCUtil.Resolve<IDriver>());
            tripManager.MakeTrip();
            Console.ReadKey();
        }

        public static class IOCUtil
        {
            private static IWindsorContainer windsorContainer = null;
            private static IWindsorContainer Container
            {
                get
                {
                    if (windsorContainer == null)
                    {
                        windsorContainer = BootStrapContainer();
                    }
                    return windsorContainer;
                }
            }
            private static IWindsorContainer BootStrapContainer()
            {
                // eğer xml konfigurasyon ile çalışmak istiyorsan alt satırda bulunan xmlInterpreteri açınız
                //if you want xlm configuration is active then remove  the comment which is below
                return new WindsorContainer(new XmlInterpreter(new ConfigResource("castle")));
                //return new WindsorContainer().Register(Component.For<IDriver>().ImplementedBy<BusDriver>(), Component.For<IPassenger>().ImplementedBy<BusPassenger>());
            }
            public static T Resolve<T>()
            {
                return Container.Resolve<T>();
            }
        }
    }
}
