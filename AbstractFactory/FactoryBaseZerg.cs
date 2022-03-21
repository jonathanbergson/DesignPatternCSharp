using System;

namespace AbstractFactory
{
    public class FactoryBaseZerg : IFactoryBase
    {
        public FactoryBaseZerg()
        {
            BuildBase();
        }
        
        public void BuildBase()
        {
            Console.WriteLine("Base Zerg criada com sucesso!");

            CoatingBaseZerg coating = new CoatingBaseZerg();
            coating.Composition();

            EnergyBaseZerg energy = new EnergyBaseZerg();
            energy.Composition();
        }
    }
}