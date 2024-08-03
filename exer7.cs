using System;
// Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês. Calcule e mostre o total do seu salário no referido mês
class Program{   
    static void Main(){
        Console.WriteLine("Salario por hora:");//13,25
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Horas Trabalhadas no mes: ");//176
        double b2 = Convert.ToDouble(Console.ReadLine());
        
        double soldo = b1 * b2;
        Console.WriteLine("Valor do salario: "+soldo);
    }
}