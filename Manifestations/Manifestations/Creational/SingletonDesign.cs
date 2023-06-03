using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manifestations.Creational
{
    internal class SingletonDesign
    {
        /// 4 ways to achieve
        /// Eager, Lazy, Synchronized Method, Double locking
        

    }

    // Eager Initialization
    public class EagerDBConnection
    {
        private static EagerDBConnection conObject = new EagerDBConnection(); //eager initialization (on class load)
        private EagerDBConnection() { }
        public static EagerDBConnection GetInstance() { return conObject; }
    }

    //Lazy Initialization
    public class LazyDBConnection
    {
        private static LazyDBConnection conObject;
        private LazyDBConnection() { }
        public static LazyDBConnection getInstance()
        {
            if (conObject == null)
            {
                conObject = new LazyDBConnection();
            }
            return conObject;
        }
    }

    //Synchronization will lock each thread, and that will be computational expensive

    //double locking - In this approach, we'll lock object and thread would be waiting
    
    public class DBConnection
    {
        private static DBConnection conObject;
        private readonly static object locker = new object();
        private DBConnection() { }
        public static DBConnection getInstance()
        {
            if (conObject == null)
            {
                lock (locker)
                {
                    if (conObject == null)
                    {
                        conObject = new DBConnection();
                    }
                }
             }
             return conObject;
            }
        }
    }
 
}
