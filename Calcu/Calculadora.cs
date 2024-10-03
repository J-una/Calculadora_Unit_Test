using System.Security.Cryptography.X509Certificates;

namespace Calcu
{
    internal class Calculadora
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciar o Programa Y/N");
            string resposta = Console.ReadLine();
            if (resposta == "N" ^ resposta == "n")
            {
                Console.WriteLine("Fechando o Programa");
                Environment.Exit(0);
            }
            else
            {


                do
                {

                    Console.WriteLine("Qual operação voce deseja realizar :");
                    Console.WriteLine("1 - Soma");
                    Console.WriteLine("2 - Subtracao");
                    Console.WriteLine("3 - Multiplicao");
                    Console.WriteLine("4 - Divisao");
                    Console.WriteLine("5 - Sair");

                    int operacao = int.Parse(Console.ReadLine());

                    while (operacao <= 0 ^ operacao > 5)
                    {
                        Console.WriteLine("Digite um numero valido");
                        operacao = int.Parse(Console.ReadLine());
                    }

                    if (operacao == 5)
                    {
                        Console.WriteLine("Saindo do Programa");
                        Environment.Exit(0);

                    }


                    Console.WriteLine("Digite o primeiro numero");
                    float numero1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo numero");
                    float numero2 = float.Parse(Console.ReadLine());

                    double resultado;
                    
                    try
                    {

                        switch (operacao)
                        {

                            case 1:
                                resultado = FuncoesCalculadora.Somar(numero1, numero2);
                                Console.WriteLine($"A soma dos dois numeros e: {resultado}");
                                break;


                            case 2:
                                resultado = FuncoesCalculadora.Subtrair(numero1, numero2);
                                Console.WriteLine($"A subtracao dos dois numeros e: {resultado}");
                                break;

                            case 3:
                                resultado = FuncoesCalculadora.Multiplicar(numero1, numero2);
                                Console.WriteLine($"A multiplicacao dos dois numeros e: {resultado}");
                                break;

                            case 4:
                                resultado = FuncoesCalculadora.Dividir(numero1, numero2);
                                Console.WriteLine($"A divisao dos dois numeros e: {resultado:F2}");
                                break;

                            case 5:
                                Environment.Exit(0);
                                break;
                        }
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Nao e possivel realizar a divisao por 0");
                    }
                    Console.WriteLine("Realizar outra operacao Y/N");
                    resposta = Console.ReadLine();

                } while (resposta == "Y" ^ resposta == "y");
            }
        } 
    }
    }
               

    public class FuncoesCalculadora
    {
        public static double Somar(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Subtrair(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Dividir(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("O divisor nao pode ser 0");
            }
            
            return num1 / num2;
        }






    }

            




