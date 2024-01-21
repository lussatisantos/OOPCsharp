using System;

class Calc{

    public int soma(int n1, int n2){
        return n1 + n2;
    }

    public int soma(int n1, int n2, int n3){
        return n1 + n2 + n3;
    }

    public int soma(params int[]N){
        int s = 0;
        for(int i = 0; i < N.Length; i++){
            s += N[i];
        }
        return s;
    }

    public double soma(params double[]N){
        double s = 0;
        for(int i = 0; i < N.Length; i++){
            s += N[i];
        }
        return s;
    }

    public int fat(int n){
        int res;
        if(n <= 1){
            res = 1;
        } else{
            res = n*fat(n-1);
        }

        return res;
    }
}

class Aula21 {
    static void Main(){
        Calc calc = new Calc();

        Console.WriteLine(calc.fat(10));
        
        /*
            Console.WriteLine(calc.soma(4, 2));
            Console.WriteLine(calc.soma(4.1, 2.7));
        */        
    }
}