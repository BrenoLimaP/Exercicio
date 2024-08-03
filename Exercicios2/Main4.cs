using System;
// Faça um programa para a leitura de duas notas parciais de um aluno. O programa deve calcular
// a média alcançada por aluno e apresentar: A mensagem "Aprovado", se a média alcançada for
// maior ou igual a sete; A mensagem "Reprovado", se a média for menor do que sete; A
// mensagem "Aprovado com Distinção", se a média for igual a dez.
class Program{   
    static void Main(){
        Console.WriteLine("Notas:");
        Console.WriteLine("Math:");
        int res = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("port:");
        int res2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingles:");
        int res4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("geografia:");
        int res5 = Convert.ToInt32(Console.ReadLine());

        int valor = (res+res2+res4+res5) / 4;

        if (valor >= 7 && valor <= 9){
            Console.WriteLine("nota " +valor+ " Aprovado");
        }
        else if (valor <= 7){
            Console.WriteLine("nota " +valor+ " Reprovado");
        }
        else if (valor == 10){
            Console.WriteLine("Aprovado com Distinção nota "+valor);
        }
        else{
            Console.WriteLine("Nao computado");
        }
    }
}