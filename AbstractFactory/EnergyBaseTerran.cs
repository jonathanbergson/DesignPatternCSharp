using System;

namespace AbstractFactory
{
    public class EnergyBaseTerran : IEnergy
    {
        public void Composition()
        {
            Console.WriteLine("Energia de sustentação da base mecânica");
        }
    }
}