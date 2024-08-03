using System;
// Faça um Programa que peça 2 números inteiros e um número real. Calcule e mostre: o produto do dobro do primeiro com metade do segundo. a soma do triplo do primeiro com o terceiro. o terceiro elevado ao cubo
class Program{   
    static void Main(){
        Console.WriteLine("2 Numeros inteiros:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("1 Numeros real:");
        double b1 = Convert.ToDouble(Console.ReadLine());

        double num3 =  (num1*2) * (num2/2);
        double num4 = (num1*3) + num3;
        double num5 = Math.Pow(num3,3);
        Console.WriteLine("Resultado:"+num3+"\n"+num4+"\n"+num5);
    }
}