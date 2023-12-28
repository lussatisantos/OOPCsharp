using System;

class Veiculo { // classe base
    public int rodas;
    public int velMax;
    private bool ligado;
    public void ligar() {
        ligado = true;
    }
    public void desligar() {
        ligado = false;
    }

    public string getLigado() {
        if(ligado) {
            return "sim";
        } else {
            return "nao";
        }
    }

}

class Carro:Veiculo { //classe herdada
    public string nome;
    public string cor;

    public Carro(string nome, string cor) {
        desligar();
        rodas = 4;
        velMax = 120;
        this.nome = nome;
        this.cor = cor; 
    }
}

class Aula07 {
    static void Main() {
        Carro car1 = new Carro("Rapidao", "Vermelho");

        Console.WriteLine("Cor: {0}" ,car1.cor);
        Console.WriteLine("Nome: {0}" ,car1.nome);
        Console.WriteLine("rodas: {0}" ,car1.rodas);
        Console.WriteLine("VelMax: {0}" ,car1.velMax);
        Console.WriteLine("Ligado: {0}" ,car1.getLigado());
    }
}