using System;
// Tendo como dados de entrada a altura de uma pessoa, construa um algoritmo que calcule seu peso ideal, usando a seguinte fórmula: 72.7*altura - 58
class Program{   
    static void Main(){
        Console.WriteLine("Altura:");
        double b1 = Convert.ToDouble(Console.ReadLine());
        // como precisar converter de double para int (ou seja explicita maior pro menor) usa esse parentes para fazer a conversão abaixo
        int ideal = (int) (72.7*b1) - 58; // int é o ideal nesse caso pq o resultado n precisa ser qeubrado, então int é melhor para reduzir espaco
        Console.WriteLine(("Seu peso ideal é:"+ideal));
    }
}