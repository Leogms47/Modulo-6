using System;
using System.Dynamic;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a quantidade de pessoas que deseja medir a altura: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++){
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("ALTURA MÉDIA = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
