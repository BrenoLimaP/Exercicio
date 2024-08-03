using System;
// Faça um Programa que peça dois números e imprima a soma
class Program{   
    static void Main(){
        Console.WriteLine("Escreva um numero:");
        int res = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escreva outro numero:");
        int res2 = Convert.ToInt32(Console.ReadLine());
        int valor = res+res2;
        Console.WriteLine("O Resultado é: "+valor);
    }
}