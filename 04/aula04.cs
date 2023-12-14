using System;

static public class Jogador {
    static public int energia;
    static public bool vivo;
    static public string nome;

    static public void iniciar(string  n) {
        energia = 100;
        vivo = true;
        nome = n;
    }

    static public void info() {
        Console.WriteLine("Nome do jogador....:{0}", nome);
        Console.WriteLine("Energia do jogador.:{0}",energia);
        Console.WriteLine("Estado do jogador..:{0}\n",vivo);
    }

}

class Inimigo {
    static public bool alerta;
    public string nome;

    public Inimigo(string n) {
        alerta = false;
        nome = n;
    }

    public void info() {
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
    }
}

class Aula04 {
    static void Main() {

        Jogador.iniciar("Lussati");
        Jogador.info();
    
        Inimigo ini1 = new Inimigo("Doido\n");
        Inimigo ini2 = new Inimigo("Maluco\n");
        Inimigo ini3 = new Inimigo("Pirado\n");

        Inimigo.alerta = true;

        ini1.info();
        ini2.info();
        ini3.info();
    }
}