using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ISmartPhoneFactory sm_factory = new HighEndSmartPhone();
            SmartPhoneShop shop = new SmartPhoneShop(sm_factory, 0);
            shop[0].GetProcessor().GetNumberOfCores();
            //shop.CreateSmartPhone(0);
            //Console.ReadKey();
            //Console.WriteLine("##############################");
            //sm_factory = new LowEndSmartPhone();
            //shop = new SmartPhoneShop(sm_factory, 1);
            //shop.CreateSmartPhone(1);
            Console.ReadKey();
        }
    }
}
