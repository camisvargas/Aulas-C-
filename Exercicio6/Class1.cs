using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio6
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Média ponderada das notas de inglês de Gabriel");

            double nota1 = 6.5;
            double nota2 = 7.8;
            double nota3 = 8.0;
            double nota4 = 7.1;
            int peso1 = 2;
            int peso2 = 3;

            Console.WriteLine("Média das notas =" + (((nota1*peso1)+(nota2*peso1)+(nota3*peso2)+(nota4*peso2))/(peso1+peso1+peso2+peso2)));
        }
    }
}
