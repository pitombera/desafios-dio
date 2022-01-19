using System;

class DIO
{
    static void Main(string[] args)
    {

        double pi, raio, volume;
        pi = 3.14159;

        // leitura do valor do raio
        raio = Double.Parse(Console.ReadLine());
        
        // cálculo de volume
        volume = (4 / 3.0) * pi * Math.Pow(raio, 3);
        Console.WriteLine("VOLUME = " + volume.ToString("#.000"));
    }
}