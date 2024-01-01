using System;

class Base {
    public Base() {
        Console.WriteLine("Construtor da classe Base");
    }

    virtual public void info() {
        Console.WriteLine("base");
    }
}

class Derivada1: Base {
    public Derivada1() {
        Console.WriteLine("Construtor da classe Derivada 1");
    }

    override public void info() {
        Console.WriteLine("derivada 1");
    }
}

class Derivada2: Derivada1 {
    public Derivada2() {
        Console.WriteLine("Construtor da classe Derivada 2");
    }

    override public void info() {
        Console.WriteLine("derivada 2");
    }
}

class Aula10 {
    static void Main(){
        Base Ref;
        Derivada1 derivada1 = new Derivada1();
        Derivada2 derivada2 = new Derivada2();

        Ref = derivada1;
        Ref.info();

        Ref = derivada2;
        Ref.info();

    /*
        derivada1.info();
        derivada2.info();
    */


    }
}