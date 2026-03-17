//Objetivos / Passo a passo

//V1
//1. Nossa calculadora deve ter a possibilidade de somar dois números [X]
//2. Nossa calculadora deve ter a possibilidade de subtrair dois números [X]
//3. Nossa calculadora deve ter a possibilidade de multiplicar dois números [X]
//4. Nossa calculadora deve ter a possibilidade de dividir dois números [X]
//5. Nossa calculadora deve permitir que o usuário continue utilizando o sistema até decidir sair [X]
//6. Nossa Cacluladora deve ter a possibilidade de executar operações em continuidade []


//V2
// Nossa calculadora deve produzir a tabuada de um numero informado
// Nossa calculadora deve armazenar o histórico de operações anteriores


//5:
//5 x 1 = 5
//5 x 2 = 10
//...


//Estruturas de Repetição
//Enquanto
///bool deveContinuarExecutando = true;
/// 
/// string texto
/// int numeros
/// bool  = true / false

//Arrays
///string[] operacoes = new string[3];
///operacoes[0] = "Não exploda 0";
///operacoes[1] = "Não exploda 1";
///operacoes[2] = "Não exploda 2";
///
///for (int iterador = 0; iterador < operacoes.Length; iterador = iterador + 1)
///{
///    Console.WriteLine(operacoes[iterador]);
///}

//return;


//Arrays
string[] historicoOperacoes = new string[100];
int contadorOperacoes = 0;

while (true == true)
{

    Console.WriteLine("----------------------------------------");
    Console.WriteLine("Calculadora 2026");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Tabuada");
    Console.WriteLine("6 - Histórico de operações");
    Console.WriteLine("S - Sair");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("Escolha uma opção válida: ");
    string opcao = Console.ReadLine();

    if (opcao == "S" || opcao == "s")
    {
        break;
    }

    if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "6")
    {
        Console.WriteLine("Escolha uma opção válida!");
        Console.ReadLine();
        return;
    }

    if (opcao == "5")
    {
        Console.Clear();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Tabuada");
        Console.WriteLine("----------------------------------------");
        Console.Write("Digite um numero inteiro: ");
        string strNumeroDigitado = Console.ReadLine();

        int numeroDigitado = Convert.ToInt32(strNumeroDigitado);

        Console.WriteLine(numeroDigitado);
        // Console.WriteLine(numeroDigitado + " x " + 1 + " = " + numeroDigitado * 1);

        for (int iterador = 1; iterador <= 10; iterador++)
        {
            //string linhaTabuada = numeroDigitado + " x " + iterador + " = " + numeroDigitado * iterador;
            string linhaTabuada = $"{numeroDigitado} x {iterador} = {numeroDigitado * iterador}";
            Console.WriteLine(linhaTabuada);
        }

        Console.WriteLine("Digite ENTER para continuar... " + numeroDigitado);
        Console.ReadLine();
        continue;
    }

    if (opcao == "6")
    {
        Console.Clear();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Histórico de Operações");
        Console.WriteLine("----------------------------------------");
        Console.Write("Digite um numero inteiro: ");
        string strNumeroDigitado = Console.ReadLine();

        for (int iterador = 1; iterador < historicoOperacoes.Length; iterador++)
        {
            if (historicoOperacoes[iterador] == null)
            {

            }
        }

        Console.WriteLine("Digite ENTER para continuar... ");
        Console.ReadLine();
        continue;
    }

    Console.Write("Digite o primeiro número: ");
    string strPrimeiroNumero = Console.ReadLine(); // texto - character string - cadeira de caracteres

    int primeiroNumero = Convert.ToInt32(strPrimeiroNumero); //numero inteiro

    Console.Write("Digite o segundo número: ");
    string strSegundoNumero = Console.ReadLine();

    int segundoNumero = Convert.ToInt32(strSegundoNumero);

    int resultado;
    string textoOperacao;

    //estrutura de decisão

    if (opcao == "1")
    {
        resultado = primeiroNumero + segundoNumero;
        textoOperacao = $"{primeiroNumero} + {segundoNumero} = {resultado}";
    }
    else if (opcao == "2")
    {
        resultado = primeiroNumero - segundoNumero;
        textoOperacao = $"{primeiroNumero} - {segundoNumero} = {resultado}";
    }

    else if (opcao == "3")
    {
        resultado = primeiroNumero * segundoNumero;
        textoOperacao = $"{primeiroNumero} * {segundoNumero} = {resultado}";
    }

    else
    {
        resultado = primeiroNumero / segundoNumero;
        textoOperacao = $"{primeiroNumero} / {segundoNumero} = {resultado}";
    }

    if (contadorOperacoes < historicoOperacoes.Length)
    {
        historicoOperacoes[contadorOperacoes] = textoOperacao;
        contadorOperacoes++;
    }

    ///int resultado = primeiroNumero + segundoNumero;

    Console.WriteLine("O resultado é: " + resultado);

    Console.ReadLine();
}