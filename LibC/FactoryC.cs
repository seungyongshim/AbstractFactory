using LibB;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibC
{
    public class FactoryC : IFactoryC
    {
        public IClassC Create()
        {
            return new ClassC();
        }
    }
}
