using System;
using System.Collections.Generic;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializando lista
            List<string> joias = new List<string>();

            // leitura inicial necessaria
            string joia = Console.ReadLine();
            // pare se leitura for nula ou vazia
            while (!string.IsNullOrWhiteSpace(joia))
            {
                // adicione na lista apenas se não existir
                if (!joias.Contains(joia)) joias.Add(joia);
                // apos uma leitura nao-vazia sempre sera necessario ler novamente
                joia = Console.ReadLine();
            }
            // impressao da contagem de joias unicas
            Console.WriteLine(joias.Count);
        }
    }
}