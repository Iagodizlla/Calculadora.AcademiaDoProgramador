using System;
using System.Data;

namespace Calculadora.ConsoleApp;

internal class Program
{
    //Variaveis globais
    static int na = 0;
    static byte[] op = new byte[99];
    static void Main(string[] args)
    {
        string[] H = new string[99];
        while (true)
        {
            op[na] = ExibirMenu();//Exibir o menu
            if (op[na] != 0)
            {
                VerificarOpcao(H);//verificar a opcao
            }
            else
            {
                break;//Finaliza o programa
            }
        }
    }
    static void Cabecalho()
    {
        Console.WriteLine("__________________________");
        Console.WriteLine("Calculadora Tabajara 2025");
        Console.WriteLine("--------------------------\n");
    }
    static byte ExibirMenu()
    {
        Console.Clear();
        Cabecalho();

        Console.WriteLine("__________________________");
        Console.WriteLine("Qual opcao vc deseja?");
        Console.WriteLine("--------------------------");

        Console.WriteLine("-0. Sair\n-1. Soma\n-2. Subtracao\n-3. Multiplicacao" +
            "\n-4. Divisao\n-5. Fatorial\n-6. Potenciacao(²)\n-7. Potenciacao(n)\n-8. Raiz_Quadrada\n-9. Tabuada" +
            "\n-10. Historico\n-11. Baskara\n-12. Numero_Primo\n-13. Media_Aritimetica");
        Console.WriteLine("--------------------------");

        byte op = byte.Parse(Console.ReadLine()!);
        return op;
    }
    static void VerificarOpcao(string[] historico)
    {
        double n1 = 0, n2 = 0, n3 = 0;

        if (op[na] >= 1 && op[na] <= 4)
        {
            //Soma, Subtracao, Multiplicacao e Divisao
            historico[na] = OperacoesBasicas(n1, n2, n3);
        }
        else if (op[na] >= 5 && op[na] <= 8)
        {
            //Fatorial, Potenciacao(²), Potenciacao(n) e Raiz Quadrada
            historico[na] = OperacoesAvancadas(n1, n2, n3);
        }
        else if (op[na] == 9)
        {
            //Tabuada
            historico[na] = OperacaoTabuada(n1, n2);
        }
        else if (op[na] == 10)
        {
            //Historico
            MostrarHistorico(historico);
        }
        else if (op[na] == 11)
        {
            //Baskara
            historico[na] = OperacaoBaskara(n1, n2, n3);
        }
        else if (op[na] == 12)
        {
            //Numero Primo
            historico[na] = OperacaoNumeroPrimo(n1);
        }
        else if (op[na] == 13)
        {
            //Media Aritmetica
            historico[na] = OperacaoMediaAritimetica(n1, n2, n3);
        }
        else
        {
            //Opcao Invalida
            Console.WriteLine("Opcao Invalida!!");
            n3--;
        }
        na++;
        Console.ReadLine();
    }
    static string OperacoesBasicas(double n1, double n2, double n3)
    {
        Console.Clear();
        Cabecalho();
        string historico = "";
        Console.Write("Digite o primeiro numero: ");
        n1 = double.Parse(Console.ReadLine()!);
        Console.Write("Digite o segundo numero: ");
        n2 = double.Parse(Console.ReadLine()!);

        //Soma
        if (op[na] == 1)
        {
            n3 = Calculadora.Somar(n1, n2);
            historico = $"{n1} + {n2} = {n3}";
        }
        //Subtracao
        else if (op[na] == 2)
        {
            n3 = Calculadora.Subtrair(n1, n2);
            historico = $"{n1} - {n2} = {n3}";
        }
        //Multiplicacao
        else if (op[na] == 3)
        {
            n3 = Calculadora.Multiplicar(n1, n2);
            historico = $"{n1} * {n2} = {n3}";
        }
        //Divisao
        else if (op[na] == 4)
        {
            while(n2 == 0)
            {
                Console.WriteLine("Nao pode divisao por zero!!!");
                Console.Write("Digite o segundo numero: ");
                n2 = double.Parse(Console.ReadLine()!);
            }
            n3 = Calculadora.Dividir(n1, n2);
            historico = $"{n1} / {n2} = {n3}";
        }
        Console.WriteLine("Resultado: " + n3.ToString("F5"));
        return historico;
    }
    static string OperacoesAvancadas(double n1, double n2, double n3)
    {
        Console.Clear();
        Cabecalho();

        string historico = "";
        Console.Write("Digite o numero: ");
        n1 = int.Parse(Console.ReadLine()!);

        //Fatorial
        if (op[na] == 5)
        {
            n3 = Calculadora.Fatorial(n1, n3);
            historico = $"{n1}! = {n3}";
        }
        //Potenciacao(²)
        else if (op[na] == 6)
        {
            n2 = 2;
            n3 = Calculadora.Potencial(n1, n2);
            historico = $"{n1} ^ 2 = {n3}";
        }
        //Potenciacao(n)
        else if (op[na] == 7)
        {
            Console.Write("Digite a potencia: ");
            n2 = int.Parse(Console.ReadLine()!);

            n3 = Calculadora.Potencial(n1, n2);
            historico = $"{n1} ^ {n2} = {n3}";
        }
        //Raiz Quadrada
        else
        {
            while(n1 < 0)
            {
                Console.WriteLine("Não existe raiz de número negativo!");
                Console.Write("Digite o numero: ");
                n1 = int.Parse(Console.ReadLine()!);
            }
            n3 = Calculadora.RaizQuadrada(n1);
            historico = $"Raiz de {n1} = {n3.ToString("F5")}";
        }
        Console.WriteLine("Resultado: " + n3.ToString("F5"));
        return historico;
    }
    static string OperacaoTabuada(double n1, double n2)
    {
        Console.Clear();
        Cabecalho();

        string historico = "";
        Console.Write("Digite o numero: ");
        n1 = int.Parse(Console.ReadLine()!);

        Console.Write("Ate que numero vai a tabuada? ");
        n2 = int.Parse(Console.ReadLine()!);
        string[] tabu = new string[(int)n2];

        Console.WriteLine("_____________");
        Console.WriteLine("Tabuada do " + n1);
        Console.WriteLine("-------------");

        //Tabuada sendo feita
        for(int i = 0; i < n2; i++)
        {
            tabu[i] = Calculadora.Tabuada(n1, n2, i);
            Console.WriteLine(tabu[i]);
        }
        historico = $"Tabuada do {n1} ao {n2}";
        return historico;
    }
    static string OperacaoBaskara(double n1, double n2, double n3)
    {
        Console.Clear();
        Cabecalho();
        string historico = "";
        double x1, x2, delta;

        Console.Write("Digite o valor de A: ");
        n1 = double.Parse(Console.ReadLine()!);
        Console.Write("Digite o valor de B: ");
        n2 = double.Parse(Console.ReadLine()!);
        Console.Write("Digite o valor de C: ");
        n3 = double.Parse(Console.ReadLine()!);

        delta = Calculadora.Delta(n1, n2, n3);

        if (delta > 0)
        {
            x1 = Calculadora.BhaskaraX1(n1, n2, delta);
            x2 = Calculadora.BhaskaraX2(n1, n2, delta);

            Console.WriteLine($"Delta: {delta.ToString("F5")}| X1: {x1.ToString("F5")}| X2: {x2.ToString("F5")}");
            historico = $"Delta: {delta.ToString("F5")}| X1: {x1.ToString("F5")}| X2: {x2.ToString("F5")}";
        }
        else if (delta == 0)
        {
            x1 = Calculadora.BhaskaraDelstaZero(n1, n2);
            Console.WriteLine($"Delta: {delta.ToString("F5")}| X: {x1.ToString("F5")}");
            historico = $"Delta: {delta.ToString("F5")}| X: {x1.ToString("F5")}";
        }
        else
        {
            Console.WriteLine($"Delta: {delta.ToString("F5")}| Não possui raizes reais");
            historico = $"Delta: {delta.ToString("F5")}| Não possui raizes reais";
        }
        return historico;
    }
    static string MostrarHistorico(string[] historico)
    {
        Console.Clear();
        Cabecalho();

        string historicoCompleto = "";
        Console.WriteLine("_________");
        Console.WriteLine("Historico");
        Console.WriteLine("---------\n");

        for (int i = 0; i < na; i++)
        {
            historicoCompleto += historico[i] + "\n";
        }
        Console.WriteLine(historicoCompleto);
        return historicoCompleto;
    }
    static string OperacaoNumeroPrimo(double n1)
    {
        Console.Clear();
        Cabecalho();
        string historico = "";
        bool zero = false;
        Console.Write("Digite o numero: ");
        n1 = int.Parse(Console.ReadLine()!);

        zero = Calculadora.NumeroPrimo(n1) == 0 ? true : false;

        if (zero == false)
        {
            Console.WriteLine("O numero " + n1 + " é primo");
            historico = $"{n1} é primo";
        }
        else
        {
            Console.WriteLine("O numero " + n1 + " não é primo");
            historico = $"{n1} não é primo";
        }
        return historico;
    }
    static string OperacaoMediaAritimetica(double n1, double n2, double n3)
    {
        Console.Clear();
        Cabecalho();
        string historico = "";
        n3 = 0;
        Console.Write("Digite a quantidade de numeros: ");
        n1 = double.Parse(Console.ReadLine()!);
        int[] n4 = new int[(int)n1];

        for (int i = 0; i < n1; i++)
        {
            Console.Write("Digite o numero: ");
            n4[i] = int.Parse(Console.ReadLine()!);
        }
        n3 = Calculadora.Media(n1, n2, n4);

        Console.WriteLine("Media: " + n3.ToString("F5"));
        historico = $"Media: {n3.ToString("F5")}";
        return historico;
    }
}