using System;
// Faça um Programa que leia um vetor de 5 números inteiros e mostre-os
class Program{   
    static void Main(){
        int[] vet1 = {20,30,40,50,60};

        foreach (int n in vet1)
        {
            Console.WriteLine(n);
        }
    }
}