using System;
// Faça um Programa que peça um número e informe se o número é inteiro ou decimal.
class Program{   
    static void Main(){
        Console.WriteLine("Escreva um numero:");
        double res = Convert.ToDouble(Console.ReadLine());


        if (res%1 == 0){
            Console.WriteLine("Numero inteiro");
        }
        else {
            Console.WriteLine("Numero decimal");
        }

    }
}