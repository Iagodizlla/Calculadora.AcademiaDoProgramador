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
         * Baskara(X)
         * Media Aritmetica(X)
         * Número Primo(X)
         * Conversor de Bases[Binario, Octal, Decimal, Hexadecimal]
         * Modo Financeiro[Juros Simples e Composto, Desconto, Acréscimo]
         * Criacao de Funcoes(Fazer em aula)
         */
        static void Main(string[] args)
        {
            //Academia do Programador

            Console.WriteLine("__________________________");
            Console.WriteLine("Calculadora Tabajara 2025");
            Console.WriteLine("--------------------------");

            //Criacao das variaveis
            double n1, n2, res;
            int n3, na = 0, n4, n5, delta;
            bool zero = false;
            byte[] op = new byte[99];
            double[] nv = new double[99];
            double[] nv2 = new double[99];
            double[] nv3 = new double[99];
            double[] n6 = new double[99];
            double[] x1 = new double[99];
            double[] x2 = new double[99];
            char[] del = new char[99];

            while (true)
            {
                res = 1;
                Console.WriteLine("\nQual opcao vc deseja?" +
                "\n1. Soma   -2. Subtracao   -3. Multiplicacao   -4. Divisao   -5. Fatorial   -6. Potenciacao(²)"+
                "\n7. Potenciacao(n)   -8. Raiz_Quadrada   -9. Tabuada   -10. Historico   -11. Baskara   -12. Numero_Primo" +
                "\n13. Media_Aritimetica   -14. Modo_Financeiro   -0. Sair");
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
                            if (n2 == 0)
                            {
                                Console.WriteLine("Nao pode divisao por zero!!!");
                                Console.ReadLine();
                                continue;
                            }
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

                        Console.WriteLine("Resultado: " + res.ToString("F5"));
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
                        Console.WriteLine("Resultado: " + res.ToString("F5"));
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
                            Console.WriteLine($"{n3} x  {i}  =  {(n3 * i)}");
                        }
                    }
                    //Historico
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
                             * Baskara(X)
                             * Numero Primo(X)
                             * Media Aritmetica(X)
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
                                Console.WriteLine(nv[i] + " / " + nv2[i] + " = " + nv3[i].ToString("F5"));
                            }
                            else if (op[i] == 5)
                            {
                                Console.WriteLine(nv[i] + "! = " + nv3[i]);
                            }
                            else if (op[i] == 6)
                            {
                                Console.WriteLine(nv[i] + " ^ 2 = " + nv3[i]);
                            }
                            else if (op[i] == 7)
                            {
                                Console.WriteLine(nv[i] + " ^ " + nv2[i] + " = " + nv3[i]);
                            }
                            else if (op[i] == 8)
                            {
                                Console.WriteLine("Raiz de " + nv[i] + " = " + nv3[i].ToString("F5"));
                            }
                            else if (op[i] == 9)
                            {
                                Console.WriteLine($"Tabuada do {nv[i]} ao {nv2[i]}");
                            }
                            else if (op[i] == 11)
                            {
                                if (del[i] == '1')
                                {
                                    Console.WriteLine($"Baskara: a: {nv[i]} b: {nv2[i]} c: {nv3[i]} || x1 = {x1[i].ToString("F5")} e x2 = {x2[i].ToString("F5")}");
                                }
                                else if (del[i] == '2')
                                {
                                    Console.WriteLine($"Baskara: a: {nv[i]} b: {nv2[i]} c: {nv3[i]} || x = {x1[i].ToString("F5")}");
                                }
                                else
                                {
                                    Console.WriteLine($"Baskara: a: {nv[i]} b: {nv2[i]} c: {nv3[i]} || Não possui raizes reais");
                                }
                            }
                            else if (op[i] == 12)
                            {
                                if (nv2[i] == 1)
                                {
                                    Console.WriteLine(nv[i] + " é primo");
                                }
                                else
                                {
                                    Console.WriteLine(nv[i] + " não é primo");
                                }
                            }
                            else if (op[i] == 13)
                            {
                                Console.Write($"Media dos numeros: (");
                                for (int j = 0; j < nv[i]; j++)
                                {
                                    if (j == nv[i] - 1)
                                    {
                                        Console.Write($" {n6[j]}) = {nv3[i].ToString("F5")}");
                                    }
                                    else
                                    {
                                        Console.Write($" {n6[j]},");
                                    }
                                }
                            }
                        }
                    }
                    //Baskara
                    else if (op[na] == 11)
                    {
                        Console.Write("Digite o valor de A: ");
                        n3 = int.Parse(Console.ReadLine());
                        Console.Write("Digite o valor de B: ");
                        n4 = int.Parse(Console.ReadLine());
                        Console.Write("Digite o valor de C: ");
                        n5 = int.Parse(Console.ReadLine());

                        delta = (int)Math.Pow(n4, 2) - 4 * n3 * n5;

                        if (delta > 0)
                        {
                            x1[na] = (double)((-n4 + Math.Sqrt(delta)) / 2 * n3);
                            x2[na] = (double)((-n4 - Math.Sqrt(delta)) / 2 * n3);
                            del[na] = '1';
                            Console.WriteLine($"Delta: {delta}, X1: {x1[na].ToString("F5")}, X2: {x2[na].ToString("F5")}");
                        }
                        else if (delta == 0)
                        {
                            x1[na] = -n4 / (2 * n3);
                            del[na] = '2';
                            Console.WriteLine($"Delta: {delta}, X: {x1[na]}");
                        }
                        else
                        {
                            del[na] = '3';
                            Console.WriteLine($"Delta: {delta.ToString("F5")}, Não possui raizes reais");
                        }
                        //Guardando os valores no hitórico
                        if (na < nv.Length)
                        {
                            nv[na] = n3;
                            nv2[na] = n4;
                            nv3[na] = n5;
                            na++;
                        }
                        //Verificando se o histórico está cheio
                        else
                        {
                            Console.WriteLine("\nHistórico cheio!\n");
                        }

                    }
                    //Numero Primo
                    else if (op[na] == 12)
                    {
                        zero = false;
                        Console.Write("Digite o numero: ");
                        n3 = int.Parse(Console.ReadLine());
                        for (int i = 2; i < n3; i++)
                        {
                            if (n3 % i == 0)
                            {
                                zero = true;
                                break;
                            }
                        }
                        if (zero == false)
                        {
                            Console.WriteLine("O numero " + n3 + " é primo");
                            n4 = 1;
                        }
                        else
                        {
                            Console.WriteLine("O numero " + n3 + " não é primo");
                            n4 = 2;
                        }
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
                    }
                    //Media Aritmetica
                    else if (op[na] == 13)
                    {
                        n6[0] = 0;
                        res = 0;
                        Console.Write("Digite a quantidade de numeros: ");
                        n1 = double.Parse(Console.ReadLine());

                        for (int i = 0; i < n1; i++)
                        {
                            Console.Write("Digite o numero: ");
                            n6[i] = double.Parse(Console.ReadLine());
                            res += n6[i];
                        }
                        res /= n1;

                        //Guardando os valores no hitórico
                        if (na < nv.Length)
                        {
                            nv[na] = n1;
                            nv3[na] = res;
                            na++;
                        }
                        //Verificando se o histórico está cheio
                        else
                        {
                            Console.WriteLine("\nHistórico cheio!\n");
                        }

                        Console.WriteLine("Media: " + res.ToString("F5"));
                    }
                    else if (op[na] == 14)
                    {
                        Console.WriteLine("Em desenvolvimento...");
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