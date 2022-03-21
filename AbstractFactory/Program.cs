using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactoryBase factory;
            
            Console.WriteLine();
            Console.WriteLine("Personagens: 1. Protoss | 2. Zergs | 3. Terranos");
            Console.Write("Escolha um dos personagens: ");

            string choice = Console.ReadLine();
            Console.WriteLine();
            
            switch (choice)
            {
                case "1":
                    factory = new FactoryBaseProtoss();
                    break;
                case "2":
                    factory = new FactoryBaseZerg();
                    break;
                case "3":
                    factory = new FactoryBaseTerran();
                    break;
            }

            Console.ReadKey();
        }
    }
}