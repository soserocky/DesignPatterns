using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Singleton
    {
        private static Singleton? _instance;
        private static object _lock = new object();

        internal static Singleton Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null) _instance = new Singleton();
                    return _instance;
                }
            }
        }
        private Singleton() { }
    }
}
