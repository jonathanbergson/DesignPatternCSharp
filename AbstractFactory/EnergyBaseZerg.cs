using System;

namespace AbstractFactory
{
    public class EnergyBaseZerg : IEnergy
    {
        public void Composition()
        {
            Console.WriteLine("Energia de sustentação da base pela terra");
        }
    }
}