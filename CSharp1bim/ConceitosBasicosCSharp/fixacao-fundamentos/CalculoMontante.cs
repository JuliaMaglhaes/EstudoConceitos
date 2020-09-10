using System;
using System.Collections.Generic;
using System.Text;

namespace fixacao_fundamentos
{
    class CalculoMontante
    {
        public void Montante()
        {
            int idadeAtual, idadeaposentado, idadeContribuindo, anos;
            double porcentagem, valorguardado, rendimento_porcentagem, rendimentoTotal, rendimentomensal;
            Console.Write("Sua idade: ");
            idadeAtual = Convert.ToInt32(Console.ReadLine());
            Console.Write("Idade que pretende se aposentar: ");
            idadeaposentado = Convert.ToInt32(Console.ReadLine());
            Console.Write("Valor guardado mensalmente: ");
            valorguardado = Convert.ToDouble(Console.ReadLine());
            Console.Write("Taxa de rendimento: ");
            porcentagem = Convert.ToDouble(Console.ReadLine());

            rendimento_porcentagem = (porcentagem / 100);
            idadeContribuindo = idadeaposentado - idadeAtual;
            anos = idadeContribuindo * 12;

            rendimentoTotal = valorguardado * (1 + rendimento_porcentagem) * ((Math.Pow(1 + rendimento_porcentagem, anos) - 1) / rendimento_porcentagem);
            rendimentomensal = valorguardado + (rendimentoTotal - (anos * valorguardado)) / anos;

            try
            {
                Console.Clear();
                Console.WriteLine(" Dados de Contribuição: ");
                Console.WriteLine(" Você irá contribuir por " + idadeContribuindo + " anos. \n");
                Console.WriteLine(" Seu rendimento mensal será de " + rendimento_porcentagem + " %.");
                Console.WriteLine(" Valor aproximado mensalmente *com rendimento: " + rendimentomensal.ToString("C"));
                Console.WriteLine(" Montante acumulado no final " + rendimentoTotal.ToString("C"));
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("\n");
                Console.WriteLine("Pressione alguma tecla para encerrar");
                Console.ReadLine();
            }

        }
    }
}
