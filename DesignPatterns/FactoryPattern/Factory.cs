using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    //Creator
    public abstract class SalesFactory
    {
        public abstract Isale GetSale();
    }

    //Concrete Creator
    public class StoreSaleFactory : SalesFactory
    {
        private decimal _extra;

        public StoreSaleFactory(decimal extra)
        {
            _extra = extra;
        }
        public override Isale GetSale()
        {
            return new StoreSale(_extra);
        }
    }

    public class InternetSaleFactory : SalesFactory
    {
        private decimal _discount;
        public InternetSaleFactory(decimal discount) 
        {
            _discount = discount;
        }
        public override Isale GetSale()
        {
            return new InternetSale(_discount);
        }
    }

    //Concrete product
    public class StoreSale : Isale
    {
        private decimal _extra;

        public StoreSale(decimal extra) 
        {
            _extra = extra;
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"la venta en tienda tiene un total de {total + _extra}");
        }
    }

    public class InternetSale : Isale
    {
        private decimal _discount;

        public InternetSale(decimal discount) 
        {
            _discount = discount;
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta por internet tiene un total de {total - _discount}");
        }
    }

    //product
    public interface Isale 
    {
        public void Sell(decimal total);
    }

}
