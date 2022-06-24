using System;

namespace AbstractFactory
{
    public class CoatingBaseProtoss : ICoating
    {
        public void Composition()
        {
            Console.WriteLine("Base revestida pela cor amarela");
        }
    }
}
