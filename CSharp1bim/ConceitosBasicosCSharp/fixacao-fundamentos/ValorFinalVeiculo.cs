using System;
using System.Collections.Generic;
using System.Text;

namespace fixacao_fundamentos
{
    class ValorFinalVeiculo
    {
        public void ValorFinal()
        {
            double valorveiculo, taxa, valorporparcela, valorcomtaxa, valortotal, taxaadm, valorfinal;
            int parcelas;
            try
            {
                Console.Write("Informe o valor do veículo: ");
                valorveiculo = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe o total de parcelas: ");
                parcelas = Convert.ToInt32(Console.ReadLine());
                Console.Write("Qual a taxa mensal: ");
                taxa = Convert.ToDouble(Console.ReadLine());

                if (taxa == 0)
                {
                    Console.Write("Caso não informem, declare como 15. *valor padrão* \n");
                    Console.Write("Qual a taxa administrativa informada pela empresa: ");
                    taxa = Convert.ToDouble(Console.ReadLine());
                    taxaadm = taxa / 100;

                    valorporparcela = taxaadm / parcelas;
                    valorcomtaxa = valorveiculo * valorporparcela;
                    valortotal = valorporparcela + valorcomtaxa;
                    valorfinal = (valortotal * parcelas) + valorveiculo;
                    Console.WriteLine("Será acrescentado " + valortotal.ToString("C") + " reais por parcela ficando o veículo no valor total de " + valorfinal.ToString("C"));

                }

                else if (taxa != 0)
                {
                    valorporparcela = valorveiculo / parcelas;
                    valorcomtaxa = valorveiculo * (taxa / 100);
                    valortotal = valorporparcela + valorcomtaxa;
                    valorfinal = valortotal * parcelas;
                    Console.WriteLine("O valor total é de " + valortotal.ToString("C") + " reais por parcela. O valor final do veículo será igual " + valorfinal.ToString("C"));
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("Fim do exercutável. Pressione alguma tecla para prosseguir");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Pressione alguma tecla para encerrar");
            Console.ReadLine();


        }
    }
}
