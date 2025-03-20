using System.ComponentModel.Design;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] historicoOperacoes = new string[100];
            int contadorHistorico = 0;


            while (true)
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("Calculadora Tabajara 2025");
                Console.WriteLine("------------------------------------------------------------");

                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Tabuada");
                Console.WriteLine("6 - Histórico de Operações");
                Console.WriteLine("S - Sair");
                Console.WriteLine("------------------------------------------------------------");
                string opcao = Console.ReadLine();

                if (opcao == "S")
                break;

                if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "6")
                {
                    Console.WriteLine("Opção inválida! Escolha uma opção válida do menu.");
                    Console.WriteLine("Pressione Enter para continuar");
                    Console.ReadLine();
                    continue;
                }

                else if (opcao == "5")
                {
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("Tabuada");
                    Console.WriteLine("------------------------------------------------------------");

                    Console.Write("Digite o número que deseja ver a tabuada: ");
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());

                    for (int contador = 1; contador <= 10; contador++)
                    {
                        int resultadomultiplicacao = numeroTabuada * contador;
                        //string LinhadaTabuada = numeroTabuada + " x " + contador + " = " + resultadomultiplicacao;
                        string LinhadaTabuada = $"{numeroTabuada} x {contador} = {resultadomultiplicacao}";
                        Console.WriteLine(LinhadaTabuada);
                    }
                    Console.WriteLine("Pressione Enter para continuar");
                    Console.ReadLine();
                    continue;
                }

                else if (opcao == "6")
                {
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("Histórico de Operações");
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("Pressione Enter para continuar");
                    for (int contador = 0; contador < contadorHistorico; contador++)
                    {
                        Console.WriteLine(historicoOperacoes[contador]);
                    }
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("------------------------------------------------------------");
                Console.Write("Digite o primeiro número: ");
                string strPrimeiroNumero = Console.ReadLine();
                decimal primeiroNumero = Convert.ToDecimal(strPrimeiroNumero);

                Console.Write("Digite o segundo número: ");
                string strSegundoNumero = Console.ReadLine();
                decimal segundoNumero = Convert.ToDecimal(strSegundoNumero);

                decimal resultado = 0.0m;

                //estrutura de decisão 
                if (opcao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
                }

                else if (opcao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} - {segundoNumero} = {resultado}";
                }
                    
                else if (opcao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} * {segundoNumero} = {resultado}";
                }

                else if (opcao == "4")
                {
                    while (segundoNumero == 0)
                    {
                        Console.WriteLine("Não é possível dividir por zero!");

                        Console.Write("Por favor, digite o segundo número novamente: ");
                        segundoNumero = Convert.ToDecimal(Console.ReadLine());
                    }

                    resultado = primeiroNumero / segundoNumero;
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} / {segundoNumero} = {resultado}";

                }
                else
                {
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    Console.ReadLine();
                    continue;
                }

                
                contadorHistorico++;

                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine($"Resultado: {resultado:F2}");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("Pressione Enter para continuar");
                Console.ReadLine();
            }
        }
    }
}
