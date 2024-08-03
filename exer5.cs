using System;
// Faça um programa que peça a altura e o comprimento de um quadrilátero e mostre a sua área.
class Program{   
    static void Main(){
        Console.WriteLine("Altura:");
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Comprimento:");
        double a1 = Convert.ToDouble(Console.ReadLine());
        
        double valor = b1 * a1;
        Console.WriteLine("o tamanho do quadrilatero é: "+valor);
    }
}