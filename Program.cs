using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubblesort
{
    class Program
    {
        public static void ordena(int[]pontuacao, string[]jogador)
        {
            for (int vezes = 0; vezes < pontuacao.Length; vezes++)
            {
                for (int i = 0; i < pontuacao.Length - 1; i++)
                {
                    if (pontuacao[i + 1] > pontuacao[i])
                    {
                        int salvar = pontuacao[i];
                        string position = jogador[i];

                        pontuacao[i] = pontuacao[i + 1];
                        pontuacao[i + 1] = salvar;

                        jogador[i] = jogador[i + 1];
                        jogador[i + 1] = position;
                    }
                }
            }
        }

        public static void posicoes(string[] jogador, int[]pontuacao)
        {
            for (int a = 0; a < 10; a++)
            {
                Console.WriteLine(a + 1 + "º colocado: " + jogador[a]);
                Console.WriteLine("Pontos: " + pontuacao[a]);
                Console.WriteLine(" ");
            }
        }

        static void Main(string[] args)
        {
            string[] jogador = { "Joao", "Jose", "Carlos", "Thiago", "Henrique",
                                 "Roberto", "Matheus", "Gustavo", "Nathan", "Airton"};
            int[] pontuacao = { 500, 350, 600, 454, 354, 198, 984, 654, 786, 846};
            bool continuar = true;

            while (continuar)
            {
                ordena(pontuacao, jogador);

                posicoes(jogador, pontuacao);

                Console.WriteLine("Insira o nome do jogador: ");
                jogador.SetValue(Console.ReadLine(), 9);
                Console.WriteLine("Insira a pontuacao do jogador: ");
                pontuacao.SetValue(int.Parse(Console.ReadLine()), 9);

                ordena(pontuacao, jogador);

                posicoes(jogador, pontuacao);
            }
                Console.ReadLine();
        }
    }
}