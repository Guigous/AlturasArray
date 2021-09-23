using System;
using System.Globalization;
using System.Linq;

namespace Alturas
{
    class Program
    {
        


        static void Main(string[] args)
        {
            //Input de dados
            Console.WriteLine("Digite o Numero de pessoas : ");
            int x= int.Parse(Console.ReadLine());
            double[] Doublearray = new double[x];
            
            //Loop
            for (int i=0;i<x;i++)

            {
                //Input de Dados
                Console.WriteLine("Digite As Alturas : ");
                double n = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture );
                Doublearray[i] = n;
            }
            //Resultado          
            double a = Doublearray.Sum();
            Console.WriteLine("A Média das alturas é : " + a/x);
            
        }
    }
}

