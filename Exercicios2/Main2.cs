using System;
// Faça um Programa que peça um valor e mostre se o valor é positivo ou negativo.
class Program{   
    static void Main(){
        Console.WriteLine("Escreva um valor");
        int res = Convert.ToInt32(Console.ReadLine());
         
        if(res >= 0){
            Console.WriteLine("É positivo");
        }
        else{
            Console.WriteLine("É negativo");
        }
    }
}