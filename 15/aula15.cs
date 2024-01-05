using System;

class Carro {
    private int[] velMax = new int[4]{10, 20, 30, 40};

    public int this[int i]{
        get {
            return velMax[i];
        }
        set {
            if(value < 0) {
                velMax[i] = 0;
            }else if (value > 300) {
                velMax[i] = 300;
            } else {
                velMax[i] = value;
            }
        }
    }

    public Carro() {

    }
}

class Aula15 {
    static void Main() {
        Carro carro = new Carro();
        
        //Console.Write("Qual a velocidade: ");
        //carro.[3] = Convert.ToInt32(Console.ReadLine());
        
        carro[2] = 200;
        Console.WriteLine("Velocidade: {0}", carro[2]);
    }
}