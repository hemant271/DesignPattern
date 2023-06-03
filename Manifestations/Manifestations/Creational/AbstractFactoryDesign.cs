using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manifestations.Creational
{
    // Factory of Factory
    internal class AbstractFactoryDesign
    {
    }

    public interface ICar
    {
        public int getTopSpeed();
    }
    public interface IAbstractFactory
    {
        ICar getInstance(int price);
    }

    public class EconomicCarFactory : IAbstractFactory
    {
        public ICar getInstance(int price)
        {
            if(price < 300000)
            {
                return new EconmicCar1();
            }
            else if (price > 300000)
            {
                return new EconmicCar2();
            }
            return null;
        }
    }

    public class LuxaryClassFactory : IAbstractFactory
    {
        public ICar getInstance(int price)
        {
            if(price >= 1000000 && price <= 2000000)
            {
                return new LuxeryCar1();
            }
            else if(price > 2000000)
            {
                return new LuxeryCar2();
            }
            return null;
        }
    }

    public class AbstractFactoryProducer
    {
        public IAbstractFactory getFactoryInstance(string value)
        {
            if (value.Equals("Economic"))
            {
                return new EconomicCarFactory();
            }
            else if(value.Equals("Luxary") || value.Equals("Premium"))
            {
                return new LuxaryClassFactory();
            }
            return null;
        }
    }
}
