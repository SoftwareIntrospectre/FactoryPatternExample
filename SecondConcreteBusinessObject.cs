using System;

namespace FactoryPattern
{
    public class SecondConcreteBusinessObject : IBusinessThingy
    {
        public SecondConcreteBusinessObject(string name)
        {
            
        }
        public void SomethingInteresting()
        {
            Console.WriteLine("Even more interesting!");
        }
    }
}
