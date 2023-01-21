using System;

namespace ModificadoresParamsRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Calculadora2.Triple(ref a);
            Console.WriteLine(a);
        }
    }
}
