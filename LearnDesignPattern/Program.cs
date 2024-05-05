using LearnDesignPattern.Creational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDesignPattern
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var factoryMethod = new FactoryMethod();
            factoryMethod.doExample();
        }
    }
}
