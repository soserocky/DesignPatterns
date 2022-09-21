using AbstractFactory.Implementations;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    internal class SamsungFactory : IFactory
    {
        
        public IMemory GetMemory()
        {
            return new Memory128GB();
        }

        public IProcessor GetProcessor()
        {
            return new Snapdragon845Processor();
        }

        public IRam GetRam()
        {
            return new Ram32GB();
        }

        public string GetDescription()
        {
            return $"Processor: {GetProcessor()}, Ram: {GetRam()}, Memory: {GetMemory()}";
        }
    }
}
