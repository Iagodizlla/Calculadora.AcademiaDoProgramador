namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        /*objetivos;
         * Soma(X)
         * Subtracao(X)
         * Multiplicacao(X)
         * Divisao(X)
         * Descobrir Raiz de numero(X)
         * Potenciacao(X)
         * Fatorial de um numero(X)
         * */
        static void Main(string[] args)
        {
            //Academia do Programador
            Console.WriteLine("__________________________");
            Console.WriteLine("Calculadora Tabajara 2025");
            Console.WriteLine("--------------------------");
            double n1, n2, res;
            int n3;
            byte op;

            do
            {
                res = 1;
                Console.WriteLine("\nQual opcao vc deseja?\n1. Soma   -2. Subtracao   -3. Multiplicacao   -4. Divisao   -5. Fatorial   -6. Potenciacao\n7. Raiz_Quadrada(Teste)   -0. Sair");
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
                        else
                        {
                            res = n1 / n2;
                        }
                        Console.WriteLine("Reultado: " + res);
                    }else if(op == 5)
                    {
                        Console.Write("Digite o numero: ");
                        n3 = int.Parse(Console.ReadLine());

                        for(int i = 1;i <= n3; i++)
                        {
                            res *= (double)i;
                        }
                        Console.WriteLine("Reultado: " + res);
                    }else if (op == 6)
                    {
                        Console.Write("Digite o numero: ");
                        n3 = int.Parse(Console.ReadLine());
                        n3 *= n3;
                        res = n3;
                        Console.WriteLine("Reultado: " + res);
                    }else if (op == 7)
                    {
                        Console.Write("Digite o numero: ");
                        n1 = double.Parse(Console.ReadLine());
                        res = Math.Sqrt(n1);
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