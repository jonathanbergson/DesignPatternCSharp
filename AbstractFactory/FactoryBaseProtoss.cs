using System;

namespace AbstractFactory
{
    public class FactoryBaseProtoss : IFactoryBase
    {
        public FactoryBaseProtoss()
        {
            BuildBase();
        }
        
        public void BuildBase()
        {
            Console.WriteLine("Base Protoss criada com sucesso!");;

            CoatingBaseProtoss coating = new CoatingBaseProtoss();
            coating.Composition();

            EnergyBaseProtoss energy = new EnergyBaseProtoss();
            energy.Composition();
        }
    }
}