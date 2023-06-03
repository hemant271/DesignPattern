using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manifestations.Creational
{
    internal class FactoryDesign
    {
        public static void main(string[] args)
        {
            ShapeInstanceFactory factoryObj = new ShapeInstanceFactory();
            IShape? circleObject = factoryObj.getShapeInstance("Circle");
            circleObject?.computeArea();
        }
    }

    public interface IShape
    {
        void computeArea();
    }

    public class Square : IShape
    {
       public void computeArea()
        {
            Console.WriteLine("Compute Square Area");
        }
    }
    public class Circle : IShape 
    {
        public void computeArea()
        {
            Console.WriteLine("Compute Circle Area");
        }
    }

    public class ShapeInstanceFactory
    {
        public IShape? getShapeInstance(string value)
        {
            if (value.Equals("Squre"))
            {
                return new Square();
            }
            else if (value.Equals("Circle"))
            {
                return new Circle();
            }
            return null;
        }
    }
}
