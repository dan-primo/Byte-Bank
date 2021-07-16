using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(222, 57412),
                new ContaCorrente(223, 57413),
                new ContaCorrente(210, 5749),
                new ContaCorrente(221, 57418)
            };

            // contas.Sort(); -> Chamar a implementacao dada em IComparable

            //contas.Sort(new ComparadorContaCorrentePorAgencia());

            //IEnumerable<ContaCorrente>
            //var contasNaoNulas = contas.Where(conta => conta != null);

            //IOrderedEnumerable<ContaCorrente>
            //var contasOrdenadas = contasNaoNulas.OrderBy(conta => conta.Numero);

            var contasOrdenadas = contas
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Numero);

            //equivalente: contas.OrderBy(conta => conta.Numero);
            // contas.OrderBy(conta => {
            //        if (conta == null)
            //        {
            //            return int.MinValue;
            //        }
            //        return conta.Numero; 
            //    });

            foreach (var conta in contasOrdenadas)
            {
                Console.WriteLine($"Número da Conta: {conta.Numero} ; Número da Agência: {conta.Agencia}");
                /*
                 * 
                    if (conta != null)
                    {
                        Console.WriteLine($"Número da Conta: {conta.Numero} ; Número da Agência: {conta.Agencia}");
                    }
                 *  
                if (conta == null)
                {
                    Console.WriteLine("Conta Nula!");
                }
                else
                {
                    Console.WriteLine($"Número da Conta: {conta.Numero} ; Número da Agência: {conta.Agencia}");
                }

                */
            }

            Console.ReadLine();
        }

        static void TestaSort()
        {
            //inferencia de tipo de variavel
            // var conta = new ContaCorrente(344, 578956);

            // var gerenciador = new GerenciadorBonificacao();

            var nomes = new List<string>()
            {
                "Zara",
                "Luci",
                "Anna",
            };

            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            var idades = new List<int>();
            // List<int> idades = new List<int>();

            idades.Add(1);
            idades.Add(16);
            idades.Add(15555);
            idades.Add(78);
            //idades.Adicionar(5);

            //idades.AddRange(1, 2, 3, 4, 5);

            //ListExtensoes.AdcionarVarios(idades, 225588, 45699885, 12456633);

            idades.AdicionarVarios(7, 777, 7777777);

            idades.AdicionarVarios(99, -1);

            idades.Sort();

            idades.Remove(78);
            //idades.Remover(78);

            //idades.Tamanho em List será idades.Count
            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }

            Console.WriteLine(SomarVarios(1, 2, 3, 5, 56465, 45));
            Console.WriteLine(SomarVarios(1, 2, 45));


            Console.ReadLine();
        }

        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.Adicionar("um texto qualquer");
            listaDeIdades.AdicionarVarios(16, 23, 60);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }
        }

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach(int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }


        static void TestaListaDeContaCorrente()
        {
            //ListaDeContaCorrente lista = new ListaDeContaCorrente();
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoGui = new ContaCorrente(11111, 1111111);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679754)
            };

            lista.AdicionarVarios(contas);

            lista.AdicionarVarios(
                contaDoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787)
            );

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }
        }



        static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
                {
                    new ContaCorrente(874, 5679787),
                    new ContaCorrente(874, 4456668),
                    new ContaCorrente(874, 7781438)
                };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }
        }

        static void TestaArrayInt()
        {
            // ARRAY de inteiros, com 5 posições!
            int[] idades = null;
            idades = new int[3];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            //idades[3] = 50;
            //idades[4] = 28;
            //idades[5] = 60;

            Console.WriteLine(idades.Length);

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");
        }

    }
}
