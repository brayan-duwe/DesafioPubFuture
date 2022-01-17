using System;
using System.Globalization;
using System.Collections.Generic;

namespace DesafioPubFuture
{
    class Program
    {
        static void Main(string[] args)
        {
            int cart, contac, poup;
            cart = 1;
            contac = 2;
            poup = 3;

            Console.Write("Qual o nome que você gostaria de dar a lista? ");
            string nome = Console.ReadLine();

            Console.Write("Quantos itens deseja adicionar à lista? ");
            int itens = int.Parse(Console.ReadLine());



            List<Receitas> list = new List<Receitas>();
            for (int i = 1; i <= itens; i++)
            {
                Console.WriteLine("Item # {0}:", i);
                Console.Write("Valor: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Data de recebimento (formato: DD MM AAAA): ");
                DateTime dataR = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de recebimento esperado (formato: DD MM AAAA): ");
                DateTime dataE = DateTime.Parse(Console.ReadLine());
                Console.Write("Descrição: ");
                string descricao = Console.ReadLine();
                Console.WriteLine("Tipo de Conta: ");
                Console.WriteLine("Digite: ");
                Console.WriteLine("1. Carteira");
                Console.WriteLine("2. Conta corrente");
                Console.WriteLine("3. Poupança");
                int tipoConta = int.Parse(Console.ReadLine());
                if (tipoConta == 1)
                {
                    Console.WriteLine("Você digitou: 1. Carteira");
                }
                else if (tipoConta == 2)
                {
                    Console.WriteLine("Você digitou 2. Conta corrente");
                }
                else
                {
                    Console.WriteLine("Você digitou 3. Poupança");
                }
                
                Console.WriteLine("Tipo da receita: ");
                string tipoReceita = Console.ReadLine();
                list.Add(new Receitas(nome, itens, preco, dataR, dataE, descricao, tipoConta, tipoReceita));
            }

            Console.WriteLine();
            Console.WriteLine("Esses são seus dados na lista {0} até agora: ", nome);
            foreach (Receitas obj in list)
            {
                Console.WriteLine(obj);
            }

                       }
        }
    }


