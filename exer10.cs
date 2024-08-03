using System;
// Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um link de Internet (em Mbps), calcule e informe o tempo aproximado de download do arquivo usando este link (em minutos)
class Program{   
    static void Main(){
        Console.WriteLine("Tamanho de arquivo (mb):");
        int tam = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("velocidade de internet (mbps):");
        int velocidade = Convert.ToInt32(Console.ReadLine());

        int tamanhomb =tam * 8;
        int tempodownload = tamanhomb / velocidade;
        Console.WriteLine("Velocidade de download:"+tempodownload);    
    }
}