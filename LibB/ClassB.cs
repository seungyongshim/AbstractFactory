﻿using LibA;
using System;

namespace LibB
{
    internal class ClassB : IClassB
    {
        IClassC _classC;

        public ClassB(IFactoryC factoryC)
        {
            _classC = factoryC.Create();
        }
    }
}