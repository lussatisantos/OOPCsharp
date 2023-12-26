using System;

class Jogador{
    public int energia;
    public string nome;

    public Jogador(string nome) {
        this.nome = nome;
        energia = 100;
    }
}

class Aula06 {
    static void Main() {
        Jogador J1 = new Jogador("Lussati");

        Console.WriteLine("Nome   : {0}", J1.nome);
        Console.WriteLine("Energia: {0}", J1.energia);
    }
}