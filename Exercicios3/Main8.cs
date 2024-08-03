using System;
// Faça um Programa que crie um vetor com 50 elementos de 0 a 50
class Program{   
    static void Main(){
        int [] array = new int [50];

        for (int i = 0; i < 50; i++)
        {
            array[i] = i+1; // o codigo aqui adiciona elementos, ou seja, na posição 0 = 1, posição 1 = 2
        }

        Console.WriteLine(array[26]);
    }
}