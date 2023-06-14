using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo2._0Milena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limitemax;
            int limitemin;
            int oculto;
            int jogador;
            int palpite;
            int njog;

            Console.WriteLine("Digite a quantidade de jogadores: ");
            njog = int.Parse(Console.ReadLine());

            string[] nomes = new string[njog];

            for (int i = 0; i < njog; i++)
            {
                Console.WriteLine("Digite o nome do jogador {0}: ", i + 1);
                nomes[i] = Console.ReadLine();
            }

            // oculto

            Random random = new Random();
            oculto = random.Next(1, 101);

            Console.Clear();

            limitemax = 100;
            limitemin = 1;

            jogador = 0;

            do
            {
                jogador = (jogador + 1) % njog;
                if (jogador == 0)
                    jogador = njog;

                Console.WriteLine("{0}, digite um valor inteiro entre {1} e {2}", nomes[jogador - 1], limitemin, limitemax);
                palpite = int.Parse(Console.ReadLine());

                Console.Clear(); // Limpa o palpite anterior

                // condição

                if (palpite == oculto)
                    Console.WriteLine(" Parabéns {0} você perdeu!", nomes[jogador - 1]);
                else if (palpite < limitemin || palpite > limitemax)
                {
                    do
                    {
                        Console.WriteLine("Digite um valor válido: ");
                        palpite = int.Parse(Console.ReadLine());
                    } while (palpite < limitemin || palpite > limitemax);

                    Console.Clear(); // Limpa o palpite inválido digitado
                }
                else if (palpite > oculto)
                    limitemax = palpite;
                else
                    limitemin = palpite;

            } while (palpite != oculto);

        }
    }
}
