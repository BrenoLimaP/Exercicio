using System;
// Faça um programa que imprima na tela apenas os números ímpares entre 1 e 50.

class Program{   
    static void Main(){
        int n = 1;
        while(n<=50){
            ++n;
            ++n;
            Console.WriteLine(n);
        }
        //int num = 0;
        //while(num <= 50){
            //if(num%2==0){
                // mostrando numeros impares
                //num++;
                //continue;
                // e o continue segue o codigo p a proxima linha
            //}
            //++n;
            //Console.WriteLine(n);
        //}
    }
}