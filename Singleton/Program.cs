using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton player01 = Singleton.Instance;
            player01.Message("Jogador 1: a bola está comigo no meio do campo.");

            Singleton player02 = Singleton.Instance;
            player02.Message("Jogador 2: recebeu a bola.");

            Singleton player03 = Singleton.Instance;
            player03.Message("Jogador 3: recebeu o lançamento na linha de fundo.");

            Console.ReadKey();
        }
    }
}