using System;

namespace AbstractFactory
{
    public class CoatingBaseZerg : ICoating
    {
        public void Composition()
        {
            Console.WriteLine("Base revestida pela cor vermelha");
        }
    }
}