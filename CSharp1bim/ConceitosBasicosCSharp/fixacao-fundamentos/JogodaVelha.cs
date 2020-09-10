using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace fixacao_fundamentos
{
    class JogodaVelha
    {
        public void Jogo()
        {
            bool partida = true;
            int jogada1, jogada2, contador = 0, jogada;
            string jogador1, jogador2;
            String[,] tabuleiro = new String [3, 3];
            string marcar;

            //Tabuleiro

            tabuleiro[0, 0] = "1";
            tabuleiro[0, 1] = "2";
            tabuleiro[0, 2] = "3";

            tabuleiro[1, 0] = "4";
            tabuleiro[1, 1] = "5";
            tabuleiro[1, 2] = "6";

            tabuleiro[2, 0] = "7";
            tabuleiro[2, 1] = "8";
            tabuleiro[2, 2] = "9";

            Console.WriteLine("Jogo da velha");
            Console.WriteLine("Nomeação de jogadores");

            Console.Write("Jogador 1, digite seu nome: ");
            jogador1 = Convert.ToString(Console.ReadLine());

            Console.Write("Jogador 2, digite seu nome: ");
            jogador2 = Convert.ToString(Console.ReadLine());

            Console.WriteLine(jogador1 + " X " + jogador2);
            Console.WriteLine("Pressione alguma tecla para continuar");
            Console.ReadLine();
            Console.Clear();

            do
            {
                try
                {
                    //Jogada 1

                    Tabuleiro();
                    Console.WriteLine("\n");
                    Console.Write("Jogador 1, escolha: ");
                    jogada1 = Convert.ToInt32(Console.ReadLine());
                    jogada = jogada1;
                    marcar = "X";

                    Marcar();
                    contador++;
                    partida = VerificarVitoria();

                    Console.Clear();

                    if (!partida)
                    {
                        Console.WriteLine("Jogador 1 ganhou. Parabéns " +jogador1);
                        break;
                    }

                    if (contador == 9)
                    {
                        Console.WriteLine("Empate! ");
                        break;

                    }

                    //Jogada 2

                    Tabuleiro();
                    Console.WriteLine("\n");
                    Console.Write("Jogador 2, escolha um número: ");
                    jogada2 = Convert.ToInt32(Console.ReadLine());
                    jogada = jogada2;
                    marcar = "O";

                    Marcar();
                    contador++;
                    partida = VerificarVitoria();

                    Console.Clear();

                    if (!partida)
                    {
                        Console.WriteLine("Jogador 2 ganhou.Parabéns " +jogador2);
                        break;

                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Apenas números");
                }

            } while ((partida == true) && (contador != 9));

            Console.WriteLine("\n");
            Console.WriteLine("Pressione alguma tecla para encerrar");
            Console.ReadLine();


            void Tabuleiro()
            {
                //Inicio

                for (int i = 0; i < 3; i++)
                {
                    Console.Write(" | " + tabuleiro[0, i]);
                }
                Console.Write(" | \n");

                //Meio

                for (int i = 0; i < 3; i++)
                {
                    Console.Write(" | " + tabuleiro[1, i]);
                }
                Console.Write(" | \n");

                //Final

                for (int i = 0; i < 3; i++)
                {
                    Console.Write(" | " + tabuleiro[2, i]);
                }
                Console.Write(" | \n");
            }
            
            void Marcar()
            {
                if (jogada == 1) { tabuleiro[0, 0] = marcar; }
                else if (jogada == 2) { tabuleiro[0, 1] = marcar; }
                else if (jogada == 3) { tabuleiro[0, 2] = marcar; }
                else if (jogada == 4) { tabuleiro[1, 0] = marcar; }
                else if (jogada == 5) { tabuleiro[1, 1] = marcar; }
                else if (jogada == 6) { tabuleiro[1, 2] = marcar; }
                else if (jogada == 7) { tabuleiro[2, 0] = marcar; }
                else if (jogada == 8) { tabuleiro[2, 1] = marcar; }
                else if (jogada == 9) { tabuleiro[2, 2] = marcar; }
            }

            bool VerificarVitoria()
            {
                // Horizontal

                if ((tabuleiro[0,0] == tabuleiro[0,1]) && (tabuleiro[0,1] == tabuleiro[0,2])) { return false; }
                else if ((tabuleiro[1,0] == tabuleiro[1,1]) && (tabuleiro[1,1] == tabuleiro[1,2])) { return false; }
                else if ((tabuleiro[2,0] == tabuleiro[2,1]) && (tabuleiro[2,1] == tabuleiro[2,2])) { return false; }

                //Vertical
                else if ((tabuleiro[0,0] == tabuleiro[1,0]) && (tabuleiro[1,0] == tabuleiro[2,0])) { return false; }
                else if ((tabuleiro[0,1] == tabuleiro[1,1]) && (tabuleiro[1,1] == tabuleiro[2,1])) { return false; }
                else if ((tabuleiro[0,2] == tabuleiro[1,2]) && (tabuleiro[1,2] == tabuleiro[2,2])) { return false; }

                //Diagonal

                else if ((tabuleiro[0,0] == tabuleiro[1,1]) && (tabuleiro[1,1] == tabuleiro[2,2])) { return false; }
                else if ((tabuleiro[0,2] == tabuleiro[1,1]) && (tabuleiro[1,1] == tabuleiro[2,0])) { return false; }

                return partida = true;
            }

        }
    }
}
