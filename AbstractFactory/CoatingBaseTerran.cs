using System;

namespace AbstractFactory
{
    public class CoatingBaseTerran : ICoating
    {
        public void Composition()
        {
            Console.WriteLine("Base revestida pela cor verde");
        }
    }
}