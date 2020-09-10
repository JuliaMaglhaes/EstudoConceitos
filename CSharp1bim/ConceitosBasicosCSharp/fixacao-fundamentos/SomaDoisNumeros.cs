using System;
using System.Collections.Generic;
using System.Text;

namespace fixacao_fundamentos
{
    class SomaDoisNumeros
    {
        public void Somar() {
            int num1; int num2; int soma;

            Console.Write("Informe o primeiro número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            soma = num1 + num2;

            Console.Clear();
            Console.WriteLine("Calculadora");
            Console.WriteLine("A soma de {0} + {1} = {2} ", num1, num2, soma);

            Console.WriteLine("\n");
            Console.WriteLine("Pressione alguma tecla para encerrar");
            Console.ReadLine();
        }       
    }
}
