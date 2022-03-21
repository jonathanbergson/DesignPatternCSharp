using System;

namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton instance = null; 

        public static Singleton Instance {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                    Console.WriteLine("Bola do Jogo...");
                }

                return instance;
            }
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}