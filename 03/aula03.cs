using System;

public class Jogador {
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador() {
        energia = 100;
        vivo = true;
        nome = "Jogador";
    } 

    public Jogador(string  n) {
        energia = 100;
        vivo = true;
        nome = n;
    }

    public Jogador(string  n, int e) {
        energia = e;
        vivo = true;
        nome = n;
    }

    public Jogador(string  n, int e, bool v) {
        energia = e;
        vivo = v;
        nome = n;
    }

    public void info() {
        Console.WriteLine("Nome do jogador....:{0}", nome);
        Console.WriteLine("Energia do jogador.:{0}",energia);
        Console.WriteLine("Estado do jogador..:{0}\n",vivo);
    }

    /*
    ~Jogador(){
        Console.WriteLine("Jogador {0} foi destruido", nome);
    }
    */
}

class Aula03 {
    static void Main() {

        /*
        Console.Write("Escreva o nome do Jogador 4: ");
        string nome1 = Console.ReadLine();
        */

        Jogador J0 = new Jogador();
        Jogador J1 = new Jogador("Tiago");
        Jogador J2 = new Jogador("Lussati", 100);
        Jogador J3 = new Jogador("Lussati Santos", 30, true);
        Jogador J4 = new Jogador("Lussati Santos", 70, false);

        J0.info();
        J1.info();
        J2.info();
        J3.info();
      

        /*
        Console.WriteLine("Nome do jogador 1: {0}", J0.nome);
        Console.WriteLine("Nome do jogador 2: {0}", J1.nome);
        Console.WriteLine("Nome do jogador 3: {0}", J2.nome);
        Console.WriteLine("Nome do jogador 4: {0}", J3.nome);
        Console.WriteLine("Nome do jogador 4: {0}", J4.nome)
        */
    }
}