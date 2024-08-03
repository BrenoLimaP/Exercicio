using System;
// Exercicio 1 - Faça um programa que peça dois numeros e mostre o maior deles
class Program{   
    static void Main(){
        Console.WriteLine("Escreva dois numeros:");
        int res = Convert.ToInt32(Console.ReadLine());
        int res2 = Convert.ToInt32(Console.ReadLine());
    
        if(res > res2){
            Console.WriteLine(+res+"É maior");
        }
        else
        {
            Console.WriteLine(+res2+"É maior");
        }
    }
}
