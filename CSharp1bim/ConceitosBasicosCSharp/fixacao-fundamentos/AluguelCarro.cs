using System;
using System.Collections.Generic;
using System.Text;

namespace fixacao_fundamentos
{
    class AluguelCarro
    {
        public void Aluguel()
        {
            int diasalugados;
            double quilometrageminicial;
            double quilometragemfinal;
            double totalprecoquilometragem;
            double totalapagar;

            Console.Write("Por quantos dias deseja alugar o carro? ");
            diasalugados = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual foi a quilometragem inicial? ");
            quilometrageminicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Qual foi a quilometragem final? ");
            quilometragemfinal = Convert.ToDouble(Console.ReadLine());

            totalprecoquilometragem = (quilometragemfinal - quilometrageminicial) * 0.35;
            totalapagar = (diasalugados * 95) + totalprecoquilometragem;

            Console.WriteLine("O valor total deu: " + totalapagar.ToString("C"));
            Console.WriteLine("\n");
            Console.WriteLine("Pressione alguma tecla para encerrar");
            Console.ReadLine();
        }
    }
}
