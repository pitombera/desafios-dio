using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // quantos leituras serao feitas
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {
                // Quantidade de esferas
                int quantidade = int.Parse(Console.ReadLine());
                // Quantidade de esferas com divisores par
                int contaEsferas = 0;

                // Da primeira esfera até a última
                for(int j = 1; j <= quantidade; j++)
                {
                    // contador de divisores
                    int qtdDivisores = 0;
                    // Percorre estrela à estrela da esfera
                    for(int estrelas = 1; estrelas <= j; estrelas++)
                    {
                        // Se for divisivel incremente o contador
                        if ((j % estrelas) == 0) qtdDivisores++;
                    }
                    // Se o total de divisores também for par, incremente o número de esfera necessário
                    if ((qtdDivisores % 2) == 0) contaEsferas++;
                }
                Console.WriteLine(contaEsferas);
            }
        }
    }
}