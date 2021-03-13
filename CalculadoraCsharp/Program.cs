using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCsharp
{
    class Program { 

        enum Menu { Soma=1, Subtracao=2, Divisao=3, Multiplicacao=4, Potencial=5, Raiz=6, Sair=7 }
    
        static void Main(string[] args)
        {
            Console.WriteLine("                       ========================================================      ");
            Console.WriteLine("                         CALCULADORA C# - RESOLVA SEUS PROBLEMAS MATÉMATICOS         ");
            Console.WriteLine("                       =========================================================     ");

            Console.Write("                                   Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("\n                        Seja bem Vindo(a), "+nome + "! Agora selecione uma opção a seguir: ");
            Console.WriteLine("\n\t\t\t\t1-Somar \n\t\t\t\t2-Subtracao \n\t\t\t\t3-Divisao \n\t\t\t\t4-Multiplicacao \n\t\t\t\t5-Potencial \n\t\t\t\t6-Raiz \n\t\t\t\t7-Sair");
            Console.Write("\n\t\t\t\tSelecionar opção: ");
            int opcao = int.Parse(Console.ReadLine());
            Menu opcaoselecionada = (Menu)opcao; 

            switch (opcaoselecionada) {
                case Menu.Soma: 
                    Somar();
                    break;
                case Menu.Subtracao:
                    Subtrair();
                    break;
                case Menu.Divisao:
                    Subtrair();
                    break;
                case Menu.Multiplicacao:
                    Multiplicar();
                    break;
                case Menu.Potencial:
                    Potencia();
                    break;
                case Menu.Raiz:
                    Raiz();
                    break;

            }

        }


        static void Somar() {
            Console.WriteLine("                   -------------------------------------------    ");
            Console.WriteLine("                          Você selecionou a função somar          ");
            Console.WriteLine("                   -------------------------------------------    ");

            int a, b;

            Console.Write("                              Digite o primeiro número: ");
            a= int.Parse(Console.ReadLine());
            Console.Write("                              Digite o segundo número: ");
            b = int.Parse(Console.ReadLine());

            int somaTotal = a + b;

            Console.WriteLine("                          O resultado da soma é: " + somaTotal);
            Console.ReadLine();
        }

        static void Subtrair()
        {
            Console.WriteLine("                   -------------------------------------------    ");
            Console.WriteLine("                          Você selecionou a função subtrair       ");
            Console.WriteLine("                   -------------------------------------------    ");

            int a, b;

            Console.Write("                           Digite o primeiro número:");
            a = int.Parse(Console.ReadLine());
            Console.Write("                            Digite o segundo número:");
            b = int.Parse(Console.ReadLine());

            int subtracaoTotal = a - b;

            Console.WriteLine("                        O resultado da subtração é: " + subtracaoTotal);
            Console.ReadLine();
        }
        static void Multiplicar()
        {
            Console.WriteLine("                   -------------------------------------------    ");
            Console.WriteLine("                          Você selecionou a função multiplicar    ");
            Console.WriteLine("                   -------------------------------------------    ");

            int a, b;

            Console.Write("                              Digite o primeiro número:");
            a = int.Parse(Console.ReadLine());
            Console.Write("                              Digite o segundo número:");
            b = int.Parse(Console.ReadLine());

            int multiplicacaoTotal = a * b;

            Console.WriteLine("                         O resultado da multiplicacao é: " + multiplicacaoTotal);
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.WriteLine("                   -------------------------------------------    ");
            Console.WriteLine("                       Você selecionou a função dividir        ");
            Console.WriteLine("                   -------------------------------------------    ");

            int a, b;

            Console.Write("                            Digite o primeiro número:");
            a = int.Parse(Console.ReadLine());
            Console.Write("                            Digite o segundo número:");
            b = int.Parse(Console.ReadLine());

            int divisaoTotal = a / b;

            Console.WriteLine("                       O resultado da divisão é: " + divisaoTotal);
            Console.ReadLine();
        }

        static void Potencia()
        {
            Console.WriteLine("                   -------------------------------------------    ");
            Console.WriteLine("                      Você selecionou a função potenciação       ");
            Console.WriteLine("                   -------------------------------------------    ");

            int a, b;

            Console.Write("                           Digite o primeiro número:");
            a = int.Parse(Console.ReadLine());
            Console.Write("                           Digite o segundo número:");
            b = int.Parse(Console.ReadLine());

            double potenciaTotal = Math.Pow(a , b);

            Console.WriteLine("                      O resultado da potência é: " + potenciaTotal);
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("                   -------------------------------------------    ");
            Console.WriteLine("                        Você selecionou a função raiz          ");
            Console.WriteLine("                   -------------------------------------------    ");
            int a;

            Console.Write("                              Digite um número:");
            a = int.Parse(Console.ReadLine());


            double raiz = Math.Sqrt(a);

            Console.WriteLine("                          A raiz é: " + raiz);
            Console.ReadLine();
        }

    }
}
