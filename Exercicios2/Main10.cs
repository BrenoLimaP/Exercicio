using System;
// Faça um programa que pergunte que horas são e consoante, diga “Bom dia”, “Boa Tarde” ou “Boa Noite”
class Program{   
    static void Main(){
        Console.WriteLine("Que horas são:");
        double res = Convert.ToDouble(Console.ReadLine());

        if (res >= 5.00 && res <= 12.00){
            Console.WriteLine("Bom dia!");
        }
        else if (res > 12.00 && res <= 18.00){
            Console.WriteLine("Boa tarde!");
        }
        else if (res >= 18.00 && res <= 24.00) {
            Console.WriteLine("boa noite!");
        }
        else{
            Console.WriteLine("horario invalido");
        }
    }
}