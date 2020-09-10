using System;
using System.Collections.Generic;
using System.Text;

namespace fixacao_fundamentos
{
    class CalculaDesconto
    {
        public void Desconto()
        {
            double valormercadoria;
            double desconto;
            double valordesconto;
            double valorfinal;

            Console.Write("Valor mercadoria: ");
            valormercadoria = Convert.ToDouble(Console.ReadLine());
            Console.Write("Desconto: ");
            desconto = Convert.ToDouble(Console.ReadLine());

            valordesconto = valormercadoria * (desconto / 100);
            valorfinal = valormercadoria - valordesconto;

            Console.Clear();
            Console.WriteLine("Valor da mercadoria antes do desconto:" + valormercadoria.ToString("C"));
            Console.WriteLine("Desconto informado: " + desconto + "%");
            Console.WriteLine("Desconto cálculado: " + valordesconto.ToString("C") + " reais");
            Console.WriteLine("Valor final com desconto: " + valorfinal.ToString("C"));

            Console.WriteLine("\n");
            Console.WriteLine("Pressione alguma tecla para encerrar");
            Console.ReadLine();
        }
    }
}
