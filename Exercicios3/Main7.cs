using System;
// Faça um Programa que leia um vetor de 10 números reais e mostre-os na ordem inversa.
class Program{   
    static void Main(){
        int[] vet1 = {10,20,30,40,50,60,70,80,90,100};
        Array.Reverse(vet1);

        foreach (int n in vet1){
            Console.WriteLine(n);
        }
    }
}