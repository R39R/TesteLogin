using System;
using System.Threading;

class Principal{
    static string user, senha, login = "Admin", senha1 = "Admin", registro;

    static void Main(){

        do{
            
            Console.WriteLine("Você já tem um usuário?");
            Console.WriteLine("Caso tenha, digite: sim");
            Console.WriteLine("Caso queira registrar um usuário, digite: não");
            Console.WriteLine("Caso queira fechar o programa, digite: fechar");
            registro = Console.ReadLine();
            Console.Clear();
        
            switch(registro){
                case "sim":
                    Console.Write("Usuário: ");
                    user = Console.ReadLine();
                    Console.Write("Senha: ");
                    senha = Console.ReadLine();
                    Console.Clear();
                    Principal.Register();
                break;

                case "não":
                    Console.Write("Usuário: ");
                    login = Console.ReadLine();
                    Console.Write("Senha: ");
                    senha1 = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Digite o seu usuario criado anteriormente.");
                    Console.Write("Usuário: ");
                    user = Console.ReadLine();
                    Console.Write("Senha: ");
                    senha = Console.ReadLine();
                    Console.Clear();
                    Principal.Register();
                break;

                default:
                break;
            } 
        } while(registro != "fechar");
        Console.Clear();
    }
        static void Register(){
        if (user == login & senha == senha1){
            for(int i=0; i<5; i++){
                Console.WriteLine("conectando...");
                Thread.Sleep(250);
            }
            Thread.Sleep(250);
            Console.Clear();
        }

        else{
            Console.WriteLine("Usuario inválido");
            Thread.Sleep(250);
        }
    }
}
