using System;
using System.Collections.Generic;
using System.Text;

namespace ModificadoresParamsRef
{
    class Calculadora2
    {
        public static void Triple(ref int x)
        {
            x = x * 3;
        }
    }
}
