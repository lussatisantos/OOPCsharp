using System;

delegate int Op(int n1, int n2);
class Mat{
    public static int soma(int n1,int n2){
        return n1 + n2;
    }
    /*
    public static int dobro(int n){
        return n * 2;
    }*/

    public static int multi(int n1,int n2){
        return n1 * n2;
    }
}

class Aul25 {
    static void Main(){
        
        int res;

        Op d1 = new Op(Mat.soma);
        res = d1(10, 40);

        Console.WriteLine("Soma: {0}",res);

        d1 = new Op(Mat.multi);
        res = d1(10, 40);

        Console.WriteLine("Multiplicacao: {0}", res);
    }
}