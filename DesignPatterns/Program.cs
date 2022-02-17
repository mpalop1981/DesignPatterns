using DesignPatterns.FactoryPattern;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //SINGLETON
            //Singleton.Log.Instance.Save("Usando log del singleton.");
            //Singleton.Log.Instance.Save("Usando log del singleton 2.");

            //FACTORY PATTERN
            SalesFactory storeSaleFactory = new StoreSaleFactory(10);
            SalesFactory internetSaleFactory = new InternetSaleFactory(2);

            Isale sale1 = storeSaleFactory.GetSale();
            sale1.Sell(15);
            Isale sale2 = internetSaleFactory.GetSale();
            sale2.Sell(15);

        }
    }
}
