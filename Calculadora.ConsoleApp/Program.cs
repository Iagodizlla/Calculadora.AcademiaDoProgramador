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
         * Historico(X, Arrumar bugs da tabuada e fatorial) - colocar o 'op' como array deve resolver
         */
        static void Main(string[] args)
        {
            //Academia do Programador
            Console.WriteLine("__________________________");
            Console.WriteLine("Calculadora Tabajara 2025");
            Console.WriteLine("--------------------------");
            double n1, n2, res;
            int n3, na = 0, n4 = 0;
            byte op;
            double[] nv = new double[99];
            double[] nv2 = new double[99];
            double[] nv3 = new double[99];

            do
            {
                res = 1;
                Console.WriteLine("\nQual opcao vc deseja?\n1. Soma   -2. Subtracao   -3. Multiplicacao   -4. Divisao   -5. Fatorial   -6. Potenciacao(²)"+
                "\n-7. Potenciacao(n)   -8. Raiz_Quadrada   -9. Tabuada   -10. Historico   -0. Sair");
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
                        //Potenciacao(²)
                        else if (op == 6)
                        {
                            res = n3 * n3;
                            //res = Math.Pow(n3, 2);
                        }
                        //Potenciacao(n)
                        else if (op == 7)
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
                    else if (op == 9)
                    {
                        Console.Write("Digite o numero: ");
                        n3 = int.Parse(Console.ReadLine());

                        Console.Write("Ate que numero vai a tabuada? ");
                        n4 = int.Parse(Console.ReadLine());

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
                        Console.WriteLine("Resultado: " + res);

                        Console.WriteLine("____________");
                        Console.WriteLine("Tabuada do " + n3);
                        Console.WriteLine("------------");

                        for (int i = 0; i <= n4; i++)
                        {
                            Console.WriteLine(n3 + " x " + i + " = " + (n3 * i));
                        }
                    }
                    else if (op == 10)
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
                             * Potenciacao(X)
                             * Fatorial(X)
                             * Tabuada
                             */

                            //Verificando a operação
                            if (nv[i] + nv2[i] == nv3[i])
                            {
                                Console.WriteLine(nv[i] + " + " + nv2[i] + " = " + nv3[i]);
                            }
                            else if ((nv[i] - nv2[i]) == nv3[i])
                            {
                                Console.WriteLine(nv[i] + " - " + nv2[i] + " = " + nv3[i]);
                            }
                            else if ((nv[i] * nv2[i]) == nv3[i])
                            {
                                Console.WriteLine(nv[i] + " * " + nv2[i] + " = " + nv3[i]);
                            }
                            else if ((nv[i] / nv2[i]) == nv3[i])
                            {
                                Console.WriteLine(nv[i] + " / " + nv2[i] + " = " + nv3[i]);
                            }
                            else if (Math.Pow(nv[i], nv2[i]) == nv3[i])
                            {
                                Console.WriteLine(nv[i] + " ^ " + nv2[i] + " = " + nv3[i]);
                            }
                            else if (Math.Sqrt(nv[i]) == nv3[i])
                            {
                                Console.WriteLine("Raiz de " + nv[i] + " = " + nv3[i]);
                            }
                            else if (Math.Pow(nv[i], 2) == nv3[i])
                            {
                                Console.WriteLine(nv[i] + " ^ 2 = " + nv3[i]);
                            }
                            else
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
            } while (op != 0);
        }
    }
}