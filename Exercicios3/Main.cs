using System;
// Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.
class Program{   
    static void Main(){
        Console.WriteLine("digite uma nota entre 0 e 10");
        int res = Convert.ToInt32(Console.ReadLine());

        while (res < 0 || res > 10){
            Console.WriteLine("valor invalido " +res);
            res = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("certo");
    }
}