using System;
using System.Collections.Generic;
using System.Text;

namespace fixacao_fundamentos
{
    class CalculaAumento
    {
        public void Aumento()
        {
            double salario;
            double aumentoporcentagem;
            double salariofinal, aumentosalario;

            Console.Write("Salário atual: ");
            salario = Convert.ToDouble(Console.ReadLine());
            Console.Write("Porcentagem de aumento: ");
            aumentoporcentagem = Convert.ToDouble(Console.ReadLine());

            salariofinal = salario + (salario * (aumentoporcentagem / 100));
            aumentosalario = salariofinal - salario;
            Console.Clear();

            Console.WriteLine("Seu antigo salário era " + salario.ToString("C"));
            Console.WriteLine("Ocorreu o aumento de " + aumentoporcentagem + "%. Aumentando: " + aumentosalario.ToString("C"));
            Console.WriteLine("O novo salário agora com o aumento equivale: " + salariofinal.ToString("C"));

            Console.WriteLine("\n");
            Console.WriteLine("Pressione alguma tecla para encerrar");
            Console.ReadLine();
        }
    }
}
