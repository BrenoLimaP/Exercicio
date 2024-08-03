using System;
// Faça um programa que receba dois números inteiros e gere os números inteiros que estão no intervalo compreendido por eles.
class Program{   
    static void Main(){
        Console.WriteLine("digite dois numeros:");
        int res = Convert.ToInt32(Console.ReadLine());
        int res2 = Convert.ToInt32(Console.ReadLine());

        for (int i = res+1; i < res2; i++) // o valor da variavel menor que o segundo valor... ai depois adiciona mais um
        {
            Console.WriteLine(i);
        }

    }
}