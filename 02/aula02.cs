using System;

public class Jogador {
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador(string  n) {
        energia = 100;
        vivo = true;

        nome = n;
    }

    ~Jogador(){
        Console.WriteLine("Jogador {0} foi destruido", nome);
    }
}

class Aula02 {
    static void Main() {

        Console.Write("Escreva o nome do Jogador 4: ");
        string nome1 = Console.ReadLine();

        Jogador J1 = new Jogador("Tiago");
        Jogador J2 = new Jogador("Paulo");
        Jogador J3 = new Jogador("Lussati");
        Jogador J4 = new Jogador(nome1);

        J1.energia = 40;
        Console.WriteLine("Nome do jogador 1: {0}", J1.nome);
        Console.WriteLine("Nome do jogador 2: {0}", J2.nome);
        Console.WriteLine("Nome do jogador 3: {0}", J3.nome);
        Console.WriteLine("Nome do jogador 4: {0}", J4.nome);
    }
}