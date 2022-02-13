using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    class Singleton
    {
        private readonly static Singleton _instance = new Singleton();

        public static Singleton Instance 
        {
            get 
            {
                return _instance;            
            }
        }
        private Singleton() { }
    }
}
