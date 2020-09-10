using System;
using System.Collections.Generic;
using System.Text;

namespace fixacao_fundamentos
{
    class MultiploDeTres
    {
        public void Multiplos()
        {
            int numero;
            Console.WriteLine("Os múltiplos de 3 são: ");
            for (numero = 0; numero <= 100; numero++)
            {
                if (numero % 3 == 0)
                {
                    Console.Write(numero + " - ");
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Pressione alguma tecla para encerrar");
            Console.ReadLine();
        }
    }
}
