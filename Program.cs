﻿using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var myObject = ObjectFactory.Create();

            myObject.SomethingInteresting();
        }
    }
}
