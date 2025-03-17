namespace Calculadora.ConsoleApp;

public static class Calculadora
{
    public static double Somar(double n1, double n2)
    {
        return n1 + n2;
    }
    public static double Subtrair(double n1, double n2)
    {
        return n1 - n2;
    }
    public static double Dividir(double n1, double n2)
    {
        return n1 / n2;
    }
    public static double Multiplicar(double n1, double n2)
    {
        return n1 * n2;
    }
    public static double Fatorial(double n1, double n3)
    {
        n3 = 1;
        for (int i = 1; i <= n1; i++)
        {
            n3 *= (double)i;
        }
        return n3;
    }
    public static double Potencial(double n1, double n2)
    {
        return Math.Pow(n1, n2);
    }
    public static double RaizQuadrada(double n1)
    {
        return Math.Sqrt(n1);
    }
    public static string Tabuada(double n1, double n2, int i)
    {
        string tabu = $"{n1} x  {i + 1}  =  {n1 * (i + 1)}";
        return tabu;
    }
    public static double Media(double n1, double n2, int[] n4)
    {
        for (int i = 0; i < n1; i++)
        {
            n2 = n2 + n4[i];
        }
        return n2 / n1;
    }
    public static double NumeroPrimo(double n1)
    {
        int cont = 0;
        for (int i = 1; i <= n1; i++)
        {
            if (n1 % i == 0)
            {
                cont++;
            }
        }
        if (cont == 2)
        {
            return 1;
        }
        else if (n1 == 1)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    public static double Delta(double n1, double n2, double n3)
    {
        return (Math.Pow(n2, 2) - 4 * n1 * n3);
    }
    public static double BhaskaraX1(double n1, double n2, double delta)
    {
        return ((-n2 + delta) / 2 * n1);
    }
    public static double BhaskaraX2(double n1, double n2, double delta)
    {
        return ((-n2 - delta) / 2 * n1);
    }
    public static double BhaskaraDelstaZero(double n1, double n2)
    {
        return (-n2 / (2 * n1));
    }
}