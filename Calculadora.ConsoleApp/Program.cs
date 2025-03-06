namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        /*objetivos;
         * Descobrir Raiz de numero
         * Raiz quadrada de um numero
         * Fatorial de um numero
         * */
        static void Main(string[] args)
        {
            //Academia do Programador
            Console.WriteLine("__________________________");
            Console.WriteLine("Calculadora Tabajara 2025");
            Console.WriteLine("--------------------------");
            double n1, n2, res = 1;
            int n3;
            byte op;

            do
            {
                Console.WriteLine("\nQual opcao vc deseja?\n1. Soma   -2. Subtracao   -3. Multiplicacao   -4. Divisao   -5. Fatorial -0. Sair");
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

                        for(int i = 1;i < n3; i++)
                        {
                            res *= (double)i;
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