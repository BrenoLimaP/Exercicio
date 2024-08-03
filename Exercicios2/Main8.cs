using System;
// Faça um Programa que peça um número correspondente a um determinado ano e em seguida informe se este ano é ou não bissexto.
class Program{   
    static void Main(){
        Console.WriteLine("digite um ano:");
        int res = Convert.ToInt32(Console.ReadLine());

        if (res%4 == 0){
            Console.WriteLine("Ano bissexto");
        }
        else{
            Console.WriteLine("Não é bissexto");
        }
    }
}