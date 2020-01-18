using System;

namespace FactoryPattern
{
    public class ConcreteBusinessObject : IBusinessThingy
    {
        public ConcreteBusinessObject(string name)
        {
            
        }

        public void SomethingInteresting()
        {
            Console.WriteLine("Amazing!");
        }
    }
}
