using System;
// Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados da área a ser pintada
// Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00.
// Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.

class Program{   
    static void Main(){
        // 1l = 3m
        // 18l = 54m
        // 1l = 80,00
        Console.WriteLine("Tamanho de metros quadrados da area (m2):");
        double area = Convert.ToDouble(Console.ReadLine());

        int latas = (int) Math.Ceiling(area/54); //arredonda para cima
        double valor = latas*80.00;

        Console.WriteLine("Numero de latas:"+latas);
        Console.WriteLine("valor a pagar:"+valor);

    }
}