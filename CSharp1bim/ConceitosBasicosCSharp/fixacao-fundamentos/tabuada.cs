using System;
using System.Collections.Generic;
using System.Text;

namespace fixacao_fundamentos
{
    class tabuada
    {
        public void Calculatabuada()
        {
            int numero, respostatabuada, contador;
            Console.Write("Informe um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Tabuada do " + numero);
            for (contador = 0; contador <= 10; contador++)
            {
                respostatabuada = numero * contador;
                Console.WriteLine(numero + " x " + contador + " = " + respostatabuada);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Pressione alguma tecla para encerrar");
            Console.ReadLine();
        }
    }
}
