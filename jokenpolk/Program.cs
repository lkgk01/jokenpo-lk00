using System;

namespace thaisplicando
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            string status = "S";
            int jogadapc;
            int vitorias = 0;
            int empates = 0;
            int derrotas = 0;
            int jogadas = 0;  // Inicializa jogadas como 0

            float winRate = 0;
            
            Console.WriteLine("vai explodir!!");
            Console.WriteLine("aperte qualquer tecla para jogar");
            Console.ReadKey();
            Console.Clear(); // limpa toda a tela 

            Console.WriteLine("digite seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("bem-vindo(a) " + nome);
            Console.ReadKey();
            Console.Clear();

            do
            {
                Console.Clear();
                
                // Calcula a taxa de vitória com base nas jogadas realizadas até o momento
                if (jogadas > 0)
                {
                    winRate = ((float)vitorias / jogadas) * 100;
                }

                Console.WriteLine("jogador " + nome + " Partidas Jogadas: " + jogadas + " vitórias: " + vitorias + " empates: "
                    + empates + " derrotas: " + derrotas + " Taxa de vitória: " + winRate.ToString("F2") + "%");
                
                Console.WriteLine("tecle 1- papel, 2- tesoura e 3- pedra");
                opcao = Console.ReadLine();

                Random aleatorio = new Random();
                jogadapc = aleatorio.Next(1, 4); // "next" sorteia número

                jogadas++;  // Atualiza o número de jogadas após cada rodada

                if (opcao == "1" && jogadapc == 1)
                {
                    Console.WriteLine("O computador jogou papel");
                    Console.WriteLine("O jogo ta empatado");
                    empates++;
                }
                else if (opcao == "2" && jogadapc == 2)
                {
                    Console.WriteLine("O computador jogou tesoura");
                    Console.WriteLine("O jogo ta empatado");
                    empates++;
                }
                else if (opcao == "3" && jogadapc == 3)
                {
                    Console.WriteLine("O computador jogou pedra");
                    Console.WriteLine("O jogo ta empatado");
                    empates++;
                }
                else if (opcao == "1" && jogadapc == 3)
                {
                    Console.WriteLine("O computador jogou pedra");
                    Console.WriteLine("Você venceu");
                    vitorias++;
                }
                else if (opcao == "2" && jogadapc == 1)
                {
                    Console.WriteLine("O computador jogou papel");
                    Console.WriteLine("Você venceu");
                    vitorias++;
                }
                else if (opcao == "3" && jogadapc == 2)
                {
                    Console.WriteLine("O computador jogou tesoura");
                    Console.WriteLine("Você venceu");
                    vitorias++;
                }
                else if (opcao == "1" && jogadapc == 2)
                {
                    Console.WriteLine("O computador jogou tesoura");
                    Console.WriteLine("Você perdeu");
                    derrotas++;
                }
                else if (opcao == "2" && jogadapc == 3)
                {
                    Console.WriteLine("O computador jogou pedra");
                    Console.WriteLine("Você perdeu");
                    derrotas++;
                }
                else if (opcao == "3" && jogadapc == 1)
                {
                    Console.WriteLine("O computador jogou papel");
                    Console.WriteLine("Você perdeu");
                    derrotas++;
                }

                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Deseja continuar? (s/n)");
                status = Console.ReadLine();

            } while (status == "s");

            Console.ReadKey(); 
        }
    }
}
