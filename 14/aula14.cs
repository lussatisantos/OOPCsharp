using System;

class Carro {
    private int velMax;

    public int vm{
        get {
            return velMax;
        }
        set {
            if(value < 0) {
                velMax = 0;
            }else if (value > 300) {
                velMax = 300;
            } else {
                velMax = value;
            }
        }
    }

    public Carro() {
        vm = 120;
    }
}

class Aula14 {
    static void Main(){
        Carro carro = new Carro();
        
        Console.Write("Qual a velocidade: ");
        carro.vm = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Velocidade: {0}", carro.vm);
    }
}