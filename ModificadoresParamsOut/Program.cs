using System;

namespace ModificadoresParamsOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triple;
            Calculadora3.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}
