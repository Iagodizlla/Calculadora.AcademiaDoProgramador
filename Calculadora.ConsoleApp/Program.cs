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
         * Tabuada(X)
         * Historico(X)
         * Saida do programa(X)
         * Baskara
         * Número Primo
         * Conversor de Bases[Binario, Octal, Decimal, Hexadecimal]
         * Modo Financeiro[Juros Simples e Composto, Desconto, Acréscimo]
         */
        static void Main(string[] args)
        {
            //Academia do Programador

            Console.WriteLine("__________________________");
            Console.WriteLine("Calculadora Tabajara 2025");
            Console.WriteLine("--------------------------");

            double n1, n2, res;
            int n3, na = 0, n4;
            bool zero = false;
            byte[] op = new byte[99];
            double[] nv = new double[99];
            double[] nv2 = new double[99];
            double[] nv3 = new double[99];

            while (true)
            {
                res = 1;
                Console.WriteLine("\nQual opcao vc deseja?\n1. Soma   -2. Subtracao   -3. Multiplicacao   -4. Divisao   -5. Fatorial   -6. Potenciacao(²)"+
                "\n-7. Potenciacao(n)   -8. Raiz_Quadrada   -9. Tabuada   -10. Historico   -0. Sair");
                op[na] = byte.Parse(Console.ReadLine());

                if (op[na] != 0)
                {
                    if (op[na] >= 1 && op[na] <= 4)
                    {
                        Console.Write("Digite o primeiro numero: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo numero: ");
                        n2 = double.Parse(Console.ReadLine());

                        //Soma
                        if (op[na] == 1)
                        {
                            res = n1 + n2;
                        }
                        //Subtracao
                        else if (op[na] == 2)
                        {
                            res = n1 - n2;
                        }
                        //Multiplicacao
                        else if (op[na] == 3)
                        {
                            res = n1 * n2;
                        }
                        //Divisao
                        else
                        {
                            res = n1 / n2;
                        }

                        //Guardando os valores no hitórico
                        if (na < nv.Length)
                        {
                            nv[na] = n1;
                            nv2[na] = n2;
                            nv3[na] = res;
                            na++;
                        }
                        //Verificando se o histórico está cheio
                        else
                        {
                            Console.WriteLine("\nHistórico cheio!\n");
                        }


                        Console.WriteLine("Resultado: " + res);
                    }
                    else if (op[na] >= 5 && op[na] <= 8)
                    {
                        Console.Write("Digite o numero: ");
                        n3 = int.Parse(Console.ReadLine());
                        //Fatorial
                        if (op[na] == 5)
                        {
                            for (int i = 1; i <= n3; i++)
                            {
                                res *= (double)i;
                            }
                        }
                        //Potenciacao(²)
                        else if (op[na] == 6)
                        {
                            res = n3 * n3;
                            //res = Math.Pow(n3, 2);
                        }
                        //Potenciacao(n)
                        else if (op[na] == 7)
                        {
                            Console.Write("Digite a potencia: ");
                            n4 = int.Parse(Console.ReadLine());

                            nv2[na] = n4;

                            //res = Math.Pow(n3, n4);
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

                        //Guardando os valores no hitórico
                        if (na < nv.Length)
                        {
                            nv[na] = n3;
                            nv3[na] = res;
                            na++;
                        }
                        //Verificando se o histórico está cheio
                        else
                        {
                            Console.WriteLine("\nHistórico cheio!\n");
                        }
                        Console.WriteLine("Resultado: " + res);
                    }
                    //Tabuada
                    else if (op[na] == 9)
                    {
                        Console.Write("Digite o numero: ");
                        n3 = int.Parse(Console.ReadLine());

                        Console.Write("Ate que numero vai a tabuada? ");
                        n4 = int.Parse(Console.ReadLine());

                        //Guardando os valores no hitórico
                        if (na < nv.Length)
                        {
                            nv[na] = n3;
                            nv2[na] = n4;
                            na++;
                        }
                        //Verificando se o histórico está cheio
                        else
                        {
                            Console.WriteLine("\nHistórico cheio!\n");
                        }

                        Console.WriteLine("____________");
                        Console.WriteLine("Tabuada do " + n3);
                        Console.WriteLine("------------");

                        //Tabuada sendo feita
                        for (int i = 0; i <= n4; i++)
                        {
                            Console.WriteLine(n3 + " x " + i + " = " + (n3 * i));
                        }
                    }
                    else if (op[na] == 10)
                    {
                        Console.WriteLine("_________");
                        Console.WriteLine("Historico");
                        Console.WriteLine("---------\n");

                        //Visualizando o histórico
                        for (int i = 0; i < na; i++)
                        {
                            /** 
                             * Soma(X)
                             * Subtracao(X)
                             * Multiplicacao(X)
                             * Divisao(X)
                             * Raiz(X)
                             * Potenciacao 2 e N(X)
                             * Fatorial(X)
                             * Tabuada(X)
                             */

                            //Verificando a operação
                            if (op[i] == 1)
                            {
                                Console.WriteLine(nv[i] + " + " + nv2[i] + " = " + nv3[i]);
                            }
                            else if (op[i] == 2)
                            {
                                Console.WriteLine(nv[i] + " - " + nv2[i] + " = " + nv3[i]);
                            }
                            else if (op[i] == 3)
                            {
                                Console.WriteLine(nv[i] + " * " + nv2[i] + " = " + nv3[i]);
                            }
                            else if (op[i] == 4)
                            {
                                Console.WriteLine(nv[i] + " / " + nv2[i] + " = " + nv3[i]);
                            }
                            else if (op[i] == 5)
                            {
                                Console.WriteLine(nv[i] + "! = " + nv3[i]);
                            }
                            else if (op[i] == 7)
                            {
                                Console.WriteLine(nv[i] + " ^ " + nv2[i] + " = " + nv3[i]);
                            }
                            else if (op[i] == 8)
                            {
                                Console.WriteLine("Raiz de " + nv[i] + " = " + nv3[i]);
                            }
                            else if (op[i] == 6)
                            {
                                Console.WriteLine(nv[i] + " ^ 2 = " + nv3[i]);
                            }
                            else if (op[i] == 9)
                            {
                                Console.WriteLine($"Tabuada do {nv[i]} ao {nv2[i]}");
                            }
                        }
                    }
                    //Opcao Invalida
                    else
                    {
                        Console.WriteLine("Opcao Invalida!!");
                    }
                }
                //Finalizando o programa
                else
                {
                    break;
                }
            }
        }
    }
}