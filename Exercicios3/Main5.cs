using System;
// Desenvolva um gerador de tabuada, capaz de gerar a tabuada de qualquer número inteiro entre 1 a 10. O usuário deve informar de qual número ele deseja ver a tabuada. 
// A saída deve ser conforme o exemplo abaixo: Tabuada de 5: 5 X 1 = 5 5 X 2 = 10 ... 5 X 10 = 50
class Program{   
    static void Main(){
        Console.WriteLine("Uma tabuada de 1 a 10? ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++){
            Console.WriteLine(n1+ "x" +i+ "=" +(n1*i));
        }
    }
}