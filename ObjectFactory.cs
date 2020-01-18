using System;

namespace FactoryPattern
{
    public static class ObjectFactory
    {
        public static IBusinessThingy Create()
        {
            var someSetting = 2;

            if(someSetting == 1)
            {
                return new ConcreteBusinessObject("thing");
            }

            else
            {
                return new SecondConcreteBusinessObject("second thing");
            }

        }
    }
}
