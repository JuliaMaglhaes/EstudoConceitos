using System;
using System.Collections.Generic;
using System.Text;

namespace fixacao_fundamentos
{
    class IRPF
    {
        public void CalculoIRPF()
        {

            double renda, rendacalculada;
            int dependentes;
            double valortotal, aliquota, reducao, dependentescalculado, inss = 0.0;
            Console.WriteLine("Cálculo IRPF");
            Console.Write("Informe sua renda: ");

            try
            {

                renda = Convert.ToDouble(Console.ReadLine());
                Console.Write("Quantidade de pessoas dependente: ");
                dependentes = Convert.ToInt32(Console.ReadLine());


                //Cálculo INSS //


                if (renda <= 1045.00)
                {
                    inss = renda * 0.075;
                }

                else if ((renda >= 1045.01) && (renda <= 2089.60))
                {
                    inss = renda * 0.09;
                }

                else if ((renda >= 2089.61) && (renda <= 3134.40))
                {
                    inss = renda * 0.12;
                }

                else if (renda >= 3134.41)
                {
                    inss = renda * 0.14;
                }

                // Cálculos restantes

                dependentescalculado = dependentes * 189.59;
                rendacalculada = renda - dependentescalculado - inss;

                if (rendacalculada <= 1903.98)
                {
                    valortotal = 0;
                    Console.Write("Isento \n");
                }

                else if ((rendacalculada >= 1903.99) && (rendacalculada <= 2826.65))
                {
                    aliquota = 7.5 / 100;
                    reducao = 142.80;
                    valortotal = rendacalculada * aliquota - reducao;
                    Console.WriteLine("Salário base: " + rendacalculada.ToString("C"));
                    Console.WriteLine("INSS: " + inss.ToString("C"));
                    Console.WriteLine("Imposto devido: " + valortotal.ToString("C"));
                }

                else if ((rendacalculada >= 2826.66) && (rendacalculada <= 3751.05))
                {
                    aliquota = 15 / 100;
                    reducao = 354.80;
                    valortotal = rendacalculada * aliquota - reducao;
                    Console.WriteLine("Salário base: " + rendacalculada.ToString("C"));
                    Console.WriteLine("INSS: " + inss.ToString("C"));
                    Console.WriteLine("Imposto devido: " + valortotal.ToString("C"));
                }

                else if ((rendacalculada >= 3751.06) && (rendacalculada <= 4664.68))
                {
                    aliquota = 22.5 / 100;
                    reducao = 636.13;
                    valortotal = rendacalculada * aliquota - reducao;
                    Console.WriteLine("Salário base: " + rendacalculada.ToString("C"));
                    Console.WriteLine("INSS: " + inss.ToString("C"));
                    Console.WriteLine("Imposto devido: " + valortotal.ToString("C") );

                }

                else if (rendacalculada >= 4464.68)
                {
                    aliquota = 27.5 / 100;
                    reducao = 868.36;
                    valortotal = rendacalculada * aliquota - reducao;
                    Console.WriteLine("Salário base: " + rendacalculada.ToString("C"));
                    Console.WriteLine("INSS: " + inss.ToString("C"));
                    Console.WriteLine("Imposto devido: " + valortotal.ToString("C"));
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Informações inseridas de forma correta. Programa rodou corretamente");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Pressione alguma tecla para encerrar");
            Console.ReadLine();
        }
    }
}
