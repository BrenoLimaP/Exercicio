using System;
// Faça um Programa que converta metros para centímetros
class Program{   
    static void Main(){
        Console.WriteLine("Metro: ");
        double n1 = Convert.ToDouble(Console.ReadLine());

        n1 *= 100;
        Console.WriteLine("Centimetros:" +n1);
    }
}