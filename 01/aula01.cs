using System;

public class Jogador {
    public int energia = 100;
    public bool vivo = true;

}

class Aula28{
    static void Main() {
        Jogador J1 = new Jogador();
        Jogador J2 = new Jogador();
        Jogador J3 = new Jogador();

        J1.energia = 40;
        Console.WriteLine("Energia do jogador 1: {0}", J1.energia);
        Console.WriteLine("Energia do jogador 2: {0}", J2.energia);
        Console.WriteLine("Energia do jogador 3: {0}", J3.energia);
    }
}