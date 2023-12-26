using System;

class Calculos{
    public int v1;
    public int v2;

    public Calculos(int v1, int v2) {
        this.v1 = v1;
        this.v2 = v2;
    }

    public int Somar() {
        return v1+v2;
    }
}

class Aula05 {
    static void Main() {
        Calculos C1 = new Calculos(10, 2);

        Console.WriteLine(C1.Somar());
    }
}