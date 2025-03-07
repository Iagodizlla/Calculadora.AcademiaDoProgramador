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
                Console.WriteLine("\nQual opcao vc deseja?\n1. Soma   -2. Subtracao   -3. Multiplicacao" +
                    "\n4. Divisao   -5. Fatorial   -6. Potenciacao(2)   -7. Potenciacao(n)   -8. Raiz_Quadrada   -9. Tabuada" +
                    "\n0. Sair");
                op = byte.Parse(Console.ReadLine());
                if (op != 0)
                {
                    if (op >= 1 && op <= 4)
                    {
                        Console.Write("Digite o primeiro numero: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo numero: ");
                        n2 = double.Parse(Console.ReadLine());

                        //Soma
                        if (op == 1)
                        {
                            res = n1 + n2;
                        }
                        //Subtracao
                        else if (op == 2)
                        {
                            res = n1 - n2;
                        }
                        //Multiplicacao
                        else if (op == 3)
                        {
                            res = n1 * n2;
                        }
                        //Divisao
                        else
                        {
                            res = n1 / n2;
                        }
                        Console.WriteLine("Reultado: " + res);
                    }
                    else if (op >= 5 && op <= 8)
                    {
                        Console.Write("Digite o numero: ");
                        n3 = int.Parse(Console.ReadLine());
                        //Fatorial
                        if (op == 5)
                        {
                            for (int i = 1; i <= n3; i++)
                            {
                                res *= (double)i;
                            }
                        }
                        //Potenciacao
                        else if (op == 6)
                        {
                            n3 *= n3;
                            res = n3;
                        }
                        //Potenciacao(n)
                        else if (op == 7)
                        {
                            Console.WriteLine("Digite a potencia: ");
                            int n4 = int.Parse(Console.ReadLine());

                            for (int i = 1; i <= n4; i++)
                            {
                                res *= n3;
                            }
                        }
                        //Raiz Quadrada
                        else
                        {
                            res = Math.Sqrt(n3);
                        }
                        Console.WriteLine("Reultado: " + res);
                    }
                    //Tabuada
                    else if (op == 9)
                    {
                        Console.Write("Digite o numero: ");
                        n3 = int.Parse(Console.ReadLine());

                        Console.Write("Ate que numero vai a tabuada? ");
                        int n4 = int.Parse(Console.ReadLine());

                        Console.WriteLine("_____________");
                        Console.WriteLine("Tabuada do "+n3);
                        Console.WriteLine("-------------");

                        for (int i = 0; i <= n4; i++)
                        {
                            Console.WriteLine(n3 + " x " + i + " = " + (n3 * i));
                        }
                    }
                    //Opcao Invalida
                    else
                    {
                        Console.WriteLine("Opcao Invalida!!");
                    }
                }
            } while (op != 0);
        }
    }
}