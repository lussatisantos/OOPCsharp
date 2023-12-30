using System;

class Veiculo { //base
    public int velAtual;
    private int velMax;
    protected bool ligado;

    public Veiculo(int velMax) {
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }

     public bool getLigado() {
         return ligado; 
    }

    public int getVelMax() {
        return velMax;
    }
}


class Carro:Veiculo { //derivada de veiculo
    public string nome;

    public Carro(string nome, int vm):base(vm) {
        this.nome = nome;
        ligado = true;
    }
}

class Aula09 {
    static void Main() {

        Carro carro = new Carro("Bonitao", 120);

        Console.WriteLine("Nome: {0}", carro.nome);
        Console.WriteLine("VelMax: {0}", carro.getVelMax());
        Console.WriteLine("Ligado: {0}", carro.getLigado());
        
    }
}