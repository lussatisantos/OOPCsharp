using System;

class Aula34 {
    static void Main(string[] args){
        
        if(args.Length > 0){
            Console.WriteLine("Qtde de argumentos: {0}" , args.Length);
            /*
            for(int i = 0; i < args.Length; i++){
                Console.WriteLine("Argumentos: {0}:{1}" , i, args[i]);
            }
            */

            int res = 0;
            for(int i = 0; i < args.Length; i++){
                res += Int32.Parse(args[i]);
            }
            Console.WriteLine("Soma: {0}",res);
        } else {
            Console.WriteLine("Nao foram passados argumentos");
        }
    }
}