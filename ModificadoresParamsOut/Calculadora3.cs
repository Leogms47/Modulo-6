using System;
using System.Collections.Generic;
using System.Text;

namespace ModificadoresParamsOut
{
    class Calculadora3
    {
        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
