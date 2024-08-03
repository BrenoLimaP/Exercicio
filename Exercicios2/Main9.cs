using System;
// Faça um Programa que leia três números e mostre o maior deles.
class Program{   
    static void Main(){
        Console.WriteLine("digite tres numeros:");
        int res = Convert.ToInt32(Console.ReadLine());
        int res2 = Convert.ToInt32(Console.ReadLine());
        int res3 = Convert.ToInt32(Console.ReadLine());

        if (res > res2 && res > res3){
            Console.WriteLine(+res+ "é o maior numero");
        }
        else if (res2 > res && res2 > res3){
            Console.WriteLine(+res2+ "é o maior numero");
        }
        else if (res3 > res && res3 > res2){
            Console.WriteLine(+res3+ "é o maior numero");
        }
    }
}