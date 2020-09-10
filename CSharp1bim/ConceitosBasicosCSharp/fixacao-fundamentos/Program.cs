using System;

//Projeto por Júlia - 4º Período
namespace fixacao_fundamentos
{
    class Menu
    {
        static void Main(string[] args)
        {  
            int marcador;
            bool programa = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Escolha um programa para rodar \n");
                Console.WriteLine("Lista de programas: \n");

                Console.WriteLine("01. Somar dois números \n" +
                    "02. Metros por Milimetros \n" +
                    "03. Calcular Aumento \n" +
                    "04. Calcular Desconto \n" +
                    "05. Calcular aluguel de Carro \n" +
                    "06. Verificar IMC \n" +
                    "07. Saída em Ordem \n" +
                    "08. Tabuada \n" +
                    "09. Múltiplos de 3 \n" +
                    "10. Fatorial \n" +
                    "11. Cálculo IRPF \n" +
                    "12. Tire a sorte \n" +
                    "13. Valor final veículo \n" +
                    "14. Calcular Montante \n" +
                    "15. Jogo da Velha \n"
                    );

                try
                {
                    Console.Write("Iniciar programa: ");
                    marcador = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    if (marcador == 01){
                        SomaDoisNumeros somar = new SomaDoisNumeros();
                        somar.Somar();
                    }
                    else if (marcador == 02){
                        MetrosMilimetros conversao = new MetrosMilimetros();
                        conversao.Conversao();
                    }
                    else if (marcador == 03){
                        CalculaAumento aumento = new CalculaAumento();
                        aumento.Aumento();
                    }
                    else if (marcador == 04){
                        CalculaDesconto desconto = new CalculaDesconto();
                        desconto.Desconto();
                    }
                    else if (marcador == 05){
                        AluguelCarro aluguel = new AluguelCarro();
                        aluguel.Aluguel();
                    }
                    else if (marcador == 06){
                        CalculaIMC imc = new CalculaIMC();
                        imc.IMC();
                    }
                    else if (marcador == 07){
                        saidaEmOrdem emordem = new saidaEmOrdem();
                        emordem.Emordem();
                    }
                    else if (marcador == 08){
                        tabuada calculatabuada = new tabuada();
                        calculatabuada.Calculatabuada();
                    }
                    else if (marcador == 09){
                        MultiploDeTres multiplos = new MultiploDeTres();
                        multiplos.Multiplos();
                    }
                    else if (marcador == 10){
                        Fatorialimpressao fatorial = new Fatorialimpressao();
                        fatorial.Fatorial();
                    }
                    else if (marcador == 11){
                        IRPF calculoirpf = new IRPF();
                        calculoirpf.CalculoIRPF();
                    }
                    else if (marcador == 12){
                        AdvinharNumero advinhar = new AdvinharNumero();
                        advinhar.Advinhar();
                    }
                    else if (marcador == 13){
                        ValorFinalVeiculo valorfinal = new ValorFinalVeiculo();
                        valorfinal.ValorFinal();
                    }
                    else if (marcador == 14){
                        CalculoMontante montante = new CalculoMontante();
                        montante.Montante();
                    }
                    else if (marcador==15){
                        JogodaVelha jogo = new JogodaVelha();
                        jogo.Jogo();
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine(" Apenas números! ");
                }

            } while (programa == true);
           
        }
    }
}
