using LibC;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibD
{
    public class FactoryD : IFactoryD
    {
        public IClassD Create()
        {
            return new ClassD();
        }
    }
}
