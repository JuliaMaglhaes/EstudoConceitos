using System;
using System.Collections.Generic;
using System.Text;

namespace fixacao_fundamentos
{
    class CalculaIMC
    {
        public void IMC()
        {
            float altura, peso, imc;
            string genero;
            Console.Write("Qual seu gênero? (Masculino ou Feminino): ");
            genero = Convert.ToString(Console.ReadLine());
            Console.Write("Qual sua altura (Utilize vírgula): ");
            altura = float.Parse(Console.ReadLine());
            Console.Write("Informe o peso: ");
            peso = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.Clear();

            Console.WriteLine("Classificação ");
            Console.WriteLine("Seu IMC deu: " + imc);

            if (imc <= 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if ((imc > 18.5) && (imc < 25))
            {
                Console.WriteLine("Peso ideal. Parabéns!");
            }

            else if ((imc >= 25) && (imc < 30))
            {
                Console.WriteLine("Sobrepeso");
            }

            else if ((imc >= 30) && (imc < 35))
            {
                Console.WriteLine("Obesidade I");
            }

            else if ((imc >= 35) && (imc < 40))
            {
                Console.WriteLine("Obesidade II (severa)");
            }

            else if (imc >= 40)
            {
                Console.WriteLine("Obesidade III (mórbida)");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Pressione alguma tecla para encerrar");
            Console.ReadLine();
        }
    }
}
