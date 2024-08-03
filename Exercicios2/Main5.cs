using System;
// Faça um Programa que peça um número inteiro e determine se ele é par ou ímpar.
class Program{   
    static void Main(){
        Console.WriteLine("digite um numero inteiro");
        int res = Convert.ToInt32(Console.ReadLine());

        if (res%2 == 0){
            Console.WriteLine("numero par");
        }
        else {
            Console.WriteLine("numero impar");
        }
    }
}