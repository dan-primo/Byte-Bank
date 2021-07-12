using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContaCorrente[] contas = new ContaCorrente[3];

            //contas[0] = new ContaCorrente(874, 2568974);
            //contas[1] = new ContaCorrente(874, 2568975);
            //contas[2] = new ContaCorrente(874, 2568976);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(874, 2568974),
                new ContaCorrente(874, 2568975),
                new ContaCorrente(874, 2568976)
            };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }

            Console.ReadLine();
        }

        static void TestaArrayInt()
        {
            // ARRAY de inteiros, com 5 posições
            int[] idades = null;
            idades = new int[5];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;

            int acumulador = 0;
            //for(int indice = 0; indice <= 4; indice++)
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            //int media = acumulador / 5;
            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");

            /*
            int idadeNoIndice4 = idades[4];

            Console.WriteLine(idadeNoIndice4);

            int[] outroArray = idades;
            Console.WriteLine(outroArray[3]);

            bool[] arrayDeBooleanos = new bool[3];

            arrayDeBooleanos[0] = true;
            arrayDeBooleanos[1] = false;
            arrayDeBooleanos[2] = true;
            */
        }
    }
}
