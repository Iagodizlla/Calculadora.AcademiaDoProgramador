namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Academia do Programador
            Console.WriteLine("________________________________");
            Console.WriteLine("Calculadora Tabajara 2025");
            Console.WriteLine("--------------------------------");
            double n1, n2, res = 0;
            byte op;
            do
            {
                Console.WriteLine("\nQual opcao vc deseja?\n1. Soma   -2. Subtracao   -3. Multiplicacao   -4. Divisao   -0. Sair");
                op = byte.Parse(Console.ReadLine());
                if (op != 0)
                {
                    if (op >= 1 && op <= 4)
                    {
                        Console.Write("Digite o primeiro numero: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o segundo numero: ");
                        n2 = double.Parse(Console.ReadLine());

                        if (op == 1)
                        {
                            res = n1 + n2;
                        }
                        else if (op == 2)
                        {
                            res = n1 - n2;
                        }
                        else if (op == 3)
                        {
                            res = n1 * n2;
                        }
                        else if (op == 4)
                        {
                            res = n1 / n2;
                        }
                        Console.WriteLine("Reultado: " + res);
                    }
                    else
                    {
                        Console.WriteLine("Opcao Invalida!!");
                    }
                }
            }while (op != 0);
        }
    }
}