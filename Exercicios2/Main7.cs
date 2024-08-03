using System;
// Faça um Programa que leia 2 números e em seguida pergunte ao usuário qual operação ele deseja realizar
class Program{   
    static void Main(){
        // Com switch
        Console.WriteLine("Escolha dois numeros:");
        int res = Convert.ToInt32(Console.ReadLine());
        int res2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Qual operação deseja realizar:");
        Console.WriteLine("1 = /");
        Console.WriteLine("2 = *");
        Console.WriteLine("3 = +");
        Console.WriteLine("4 = -");
        string resposta = (Console.ReadLine());

        switch(resposta){
            case "1": 
                Console.WriteLine(res/res2);
                break;
            case "2": 
                Console.WriteLine(res*res2);
                break;
            case "3": 
                Console.WriteLine(res+res2);
                break;
            case "4": 
                Console.WriteLine(res-res2);
                break;
        }

        // ----------------------------------------------------------------------------
        // MINHA MANEIRA DE FAZER
        //Console.WriteLine("Escolha dois numeros:");
        //int res = Convert.ToInt32(Console.ReadLine());
        //int res2 = Convert.ToInt32(Console.ReadLine());

        //pergunta:
        //Console.WriteLine("Qual operação deseja realizar:(/,*,-,+)");
        //string res3 = (Console.ReadLine());

        //if (res3 == "/"){
            //int result = res/res2;
            //Console.WriteLine("O resultado é "+result );
        //}
        //else if(res3 == "*"){
            //int result2 = res*res2;
            //Console.WriteLine("O resultado é "+result2 );
        //}
        //else if(res3 == "-"){
            //int result3 = res-res2;
            //Console.WriteLine("O resultado é "+result3 );
        
            
        //}
        //else if(res3 == "+"){
            //int result4 = res+res2;
            //Console.WriteLine("O resultado é "+result4);
            
        //}
        //else{
            //Console.WriteLine("Invalido");
            //goto pergunta;
        //}
    }
        
}