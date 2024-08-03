using System;
// Faça um programa que peça o raio de um círculo e calcule a sua área.
class Program{   
    static void Main(){
        Console.WriteLine("Raio do Circulo:");
        double b1 = Convert.ToDouble(Console.ReadLine());

        double valor = Math.PI*Math.Pow(b1,2);
        Console.WriteLine("Resultado:"+valor);
        Console.WriteLine("Arredondado:"+Math.Round(valor));
    }
}