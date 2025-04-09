using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pedra_papel_tesoura
{
    class Program
    {
        static void Main(string[] args)
        {
            string status = "0";
            do
            {
                Console.Clear();
                Console.WriteLine("JOKENPO");
                int vitorias = 0;
                int empates = 0;
                int derrotas = 0;
                string nome = "";
                status = "1";
                int vitorias1 = 0; 
                int empates12 = 0;
                int derrotas1 = 0;
                int vitorias2 = 0;
                int derrotas2 = 0;
                string nome1 = "";
                string nome2 = "";
                while (status == "1")
             
                {

                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Pressione [1] para singleplayer - [2] para multplayer  [q] para sair");
                    string modo = Console.ReadLine();

                    if (modo == "1")
                    {
                        status = "11";
                    }
                    else if (modo =="2")
                    {
                        status = "12";
                    } else if(modo == "q") {
                        Environment.Exit(0);
                    } ;

                };
                while (status == "11")
                {
                    if (nome == "")
                    {
                        Console.WriteLine("digite seu nome");
                        nome = Console.ReadLine();
                        Console.WriteLine("Hello world " + nome);
                    }
                        Console.Clear();
                        Console.WriteLine("jogador: " + nome + "      Vitorias:" + vitorias + "   derrotas: " + derrotas + "   empates: " + empates);
                        Random numero = new Random();
                        int jogadaPc = numero.Next(1, 4);

                    
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("1 para papel, 2 para tesoura, 3 para pedra");
                    int player = int.Parse(Console.ReadLine());
                    if (player == jogadaPc)
                    {
                        Console.WriteLine("empate");
                        empates++;
                        Console.ReadKey();
                    }
                    else if ((jogadaPc == 1 && player == 2) ||
                           (jogadaPc == 2 && player == 3) ||
                           (jogadaPc == 3 && player == 1))
                    {
                        Console.WriteLine("voce venceu");
                        vitorias++;
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("voce perdeu");
                        derrotas++;
                        Console.ReadKey();
                    }
                    Console.Clear();
                    Console.WriteLine("quer jogar novamente? ");
                    Console.WriteLine("[1] sim, [2] não");
                    string decisão = Console.ReadLine();
                    if (decisão == "1")
                    {
                        status = "11";
                    }
                    else if (decisão == "2")
                    {
                        status = "1";
                    }



                }
                while (status == "12")
                {
                    Console.Clear ();
                    if (nome1 == "" || nome2 == "")
                    {
                        Console.WriteLine("Jogador 1 digite seu NOME");
                        nome1 = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Jogador 2 digite seu NOME");
                        nome2 = Console.ReadLine();
                        Console.Clear();
                    }
                    Console.WriteLine(nome1+"      Vitorias:" + vitorias1 + "   derrotas: " + derrotas1 + "   empates: " + empates12);
                    Console.WriteLine(nome2+"      Vitorias:" + vitorias2 + "   derrotas: " + derrotas2 + "   empates: " + empates12);
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine(nome1+": 1 para papel, 2 para tesoura, 3 para pedra");
                    int escolhapl1 = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine(nome2+": 1 para papel, 2 para tesoura, 3 para pedra");
                    int escolhapl2 = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (escolhapl1 == escolhapl2)
                    {
                        empates++;
                        Console.WriteLine("empate!");
                    }
                    else if (escolhapl1 == 1 && escolhapl2 == 2 || escolhapl1 == 2 && escolhapl2 == 3 || escolhapl1 == 3 && escolhapl2 == 1)
                    {
                        Console.WriteLine(nome2+" Venceu!");
                        vitorias2++;
                        derrotas1++; 
                    } else
                    {
                        Console.WriteLine(nome1+" Venceu!");
                        vitorias1++;
                        derrotas2++;
                    };
                    Console.WriteLine("jogar novamente?    [1]sim    [2] não");
                    int escolha = int.Parse(Console.ReadLine());

                        if (escolha == 1)
                        {
                            status = "12";
                        }
                        else if(escolha == 2)
                        {
                            status = "0";
                        }

                }

            } while (status == "0");
        }
    }
}
