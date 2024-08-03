using System;
// Faça um Programa que verifique se uma letra digitada é "F" ou "M". Conforme a letra escrever: F - Feminino, M - Masculino, Sexo Inválido
class Program{   
    static void Main(){
        Console.WriteLine("Voce é:(F/M)");
        string res = Console.ReadLine();

        if (res == "f"){
            Console.WriteLine("Voce é femea");
        }
        else if (res == "m"){
            Console.WriteLine("Voce é macho");
        }
        else{
            Console.WriteLine("jo lo no conosco senior");
        }
    }
}