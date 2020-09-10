using System;
using System.Collections.Generic;
using System.Text;

namespace fixacao_fundamentos
{
    class saidaEmOrdem
    {
        public void Emordem()
        {
            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    if (coluna > linha)
                    {
                        break;
                    }
                    Console.Write(coluna + 1);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            Console.WriteLine("Pressione alguma tecla para encerrar");
            Console.ReadLine();
        }
    }
}
