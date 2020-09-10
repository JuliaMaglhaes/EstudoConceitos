using System;
using System.Collections.Generic;
using System.Text;

namespace fixacao_fundamentos
{
    class AdvinharNumero
    {
        public void Advinhar()
        {
            int numero, contador;
            int NumeroSorteado = new Random().Next(0, 100);
            Console.WriteLine("Tente descobrir o número que irei sortear de 0 a 100. Você possui 10 chances");

            for (contador = 1; contador <= 10; contador++)
            {
                try
                {
                    Console.Write("Digite um número: ");
                    numero = Convert.ToInt32(Console.ReadLine());

                    if (numero == NumeroSorteado)
                    {
                        Console.Write(" Você acertouu! ");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Errou!");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Apenas números");
                }

            }
            Console.WriteLine("Número sorteado era: " + NumeroSorteado);
            Console.WriteLine("Pressione alguma tecla para encerrar");
            Console.ReadLine();
        }
    }
}
