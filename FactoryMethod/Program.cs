using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod fm = new FactoryMethod();

            Console.WriteLine();
            Console.Write("Lista de personagens: ");
            Console.WriteLine("Liu Kang | SubZero | Scorpion");
            Console.Write("Escolha seu personagem: ");
            string choise = Console.ReadLine();

            ICharacter character = fm.ChooseCharacter(choise);
            
            Console.Write("\nVocê irá jogar com... ");
            character.Chosen();

            Console.ReadKey();
        }
    }
}
