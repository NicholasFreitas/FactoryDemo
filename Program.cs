using System;
using System.Collections.Generic;

namespace FactoryDemo
{
    /*Allows defferment of class creation to subclasses through an interface*/

        /*
          ------------          --------------------
          |IProduct  |          |IFactory          |
          ------------          --------------------
          |          |          |IProduct Create() |
          ------------          --------------------
               |                         |
               | is-a                    | is-a
               V                         V
               V                         V
          -------------         ---------------------
          |ProductOne |         |ConcreteFactoryOne |
          -------------         ---------------------
          |           |         |IProduct Create()  |
          -------------         ---------------------
         
         
         
         */




    class Program
    {
        static void Main(string[] args)
        {
            List<IFactory> factoryList = new List<IFactory>();

            factoryList.Add(new ConcreteFactoryOne());
            factoryList.Add(new ConcreteFactoryTwo());

            List<IProduct> productList = new List<IProduct>();
            

            foreach (var factory in factoryList)
            {
                productList.Add(factory.Create());
            }

            Console.ReadLine();

        }
    }
}
