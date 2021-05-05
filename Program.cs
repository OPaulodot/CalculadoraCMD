using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        enum Opção {Soma=1, Subtração, Multiplicação, Divisão, Potencia, Raiz }

        static void Main(string[] args)
        {
            bool Sair = false;
            while (Sair == false) 
            { 

                Console.WriteLine("Selecione a operação desejada");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Multiplicação\n4-Divisão\n5-Potencia\n6-Raiz\n7-Sair");
                int index = int.Parse(Console.ReadLine());
                Opção OpçãoSelecionada = (Opção)index;
                Console.Clear();
            

                switch (OpçãoSelecionada)
                {
                    case Opção.Soma:
                        Somar();
                        break;
                    case Opção.Subtração:
                        Subtrair();
                        break;
                    case Opção.Multiplicação:
                        Multiplicar();
                        break;
                    case Opção.Divisão:
                        Dividir();
                        break;
                    case Opção.Potencia:
                        Potencia();
                        break;
                    case Opção.Raiz:
                        Raiz();
                        break;
                    default:
                        Sair = true;
                        break;
                }

                
            }

            

        }
        
        static void Somar()
        {
            int a;
            int b;

            Console.WriteLine("Insira o primeiro número: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número: ");
            b = int.Parse(Console.ReadLine());
            int Resultado = a + b;
            Console.WriteLine($"O resultado da operação é: {Resultado}");
            Console.WriteLine("Pressione ENTER para voltar ao menu");
            Console.ReadLine();
            Console.Clear();
        }
        static void Subtrair() 
        {
            int a;
            int b;

            Console.WriteLine("Insira o primeiro número: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número: ");
            b = int.Parse(Console.ReadLine());
            int Resultado = a - b;
            Console.WriteLine($"O resultado da operação é: {Resultado}");
            Console.WriteLine("Pressione ENTER para voltar ao menu");
            Console.ReadLine();
            Console.Clear();
        }
        static void Multiplicar() 
        {
            int a;
            int b;

            Console.WriteLine("Insira o primeiro número: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número: ");
            b = int.Parse(Console.ReadLine());
            int Resultado = a * b;
            Console.WriteLine($"O resultado da operação é: {Resultado}");
            Console.WriteLine("Pressione ENTER para voltar ao menu");
            Console.ReadLine();
            Console.Clear();
        }
        static void Dividir() 
        {
            int a;
            int b;

            Console.WriteLine("Insira o primeiro número: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número: ");
            b = int.Parse(Console.ReadLine());
            int Resultado = a / b;
            Console.WriteLine($"O resultado da operação é: {Resultado}");
            Console.WriteLine("Pressione ENTER para voltar ao menu");
            Console.ReadLine();
            Console.Clear();
        }
        static void Potencia() 
        {
            int a;
            int b;

            Console.WriteLine("Insira o a base: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o expoente: ");
            b = int.Parse(Console.ReadLine());
            double Resultado = Math.Pow(a, b);
            Console.WriteLine($"O resultado da operação é: {Resultado}");
            Console.WriteLine("Pressione ENTER para voltar ao menu");
            Console.ReadLine();
            Console.Clear();
        }
        static void Raiz() 
        {
            int a;
            
            Console.WriteLine("Insira o primeiro número: ");
            a = int.Parse(Console.ReadLine());
            double Resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado da operação é: {Resultado}");
            Console.WriteLine("Pressione ENTER para voltar ao menu");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
