using System;
using System.Collections.Generic;
using System.Text;

namespace fixacao_fundamentos
{
    class Fatorialimpressao
    {
        public void Fatorial()
        {
            Console.WriteLine("Impressão Fatorial");
            int numero, fatorial = 1;
            for (numero = 1; numero <= 10; numero++)
            {
                fatorial = fatorial * numero;
                Console.WriteLine("O fatorial de " + numero + " é " + fatorial);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Pressione alguma tecla para encerrar");
            Console.ReadLine();
        }
    }
}
