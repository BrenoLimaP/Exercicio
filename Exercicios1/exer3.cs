using System;
// Faça um Programa que peça as 4 notas bimestrais e mostre a média
class Program{   
    static void Main(){
        Console.WriteLine("Nota Matematica: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nota Quimica: ");
        double n2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nota galo de briga: ");
        double n3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nota jogo do bicho: ");
        double n4 = Convert.ToDouble(Console.ReadLine());

        double Soma = n1+n2+n3+n4;
        double Media = Soma / 4; // divisão
        //ou
        // Int Soma = (n1+n2+n3+n4)/4;
        Console.WriteLine("A Media é: "+Media);

    }
}