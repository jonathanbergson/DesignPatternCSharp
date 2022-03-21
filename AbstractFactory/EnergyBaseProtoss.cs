using System;

namespace AbstractFactory
{
    public class EnergyBaseProtoss : IEnergy
    {
        public void Composition()
        {
            Console.WriteLine("Energia de sustentação da base com cristais");
        }
    }
}