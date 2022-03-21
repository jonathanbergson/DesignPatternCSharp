using System;

namespace AbstractFactory
{
    public class FactoryBaseTerran : IFactoryBase
    {
        public FactoryBaseTerran()
        {
            BuildBase();
        }
        
        public void BuildBase()
        {
            Console.WriteLine("Base Terran criada com sucesso!");

            CoatingBaseTerran coating = new CoatingBaseTerran();
            coating.Composition();

            EnergyBaseTerran energy = new EnergyBaseTerran();
            energy.Composition();
        }
    }
}