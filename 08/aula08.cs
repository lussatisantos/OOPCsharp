using System;

class Veiculo { // classe base
    private int rodas;
    public int velMax;
    private bool ligado;

    public Veiculo(int rodas) {
        this.rodas = rodas;
    }

    public void ligar() {
        ligado = true;
    }
    public void desligar() {
        ligado = false;
    }

    public string getLigado() {
        return (ligado?"sim":"nao");
    }

    public int getRodas() {
        return rodas;
    }

    public void setRodas(int rodas) {
        if(rodas < 0) {
            this.rodas = 0;
        }else if(rodas > 40) {
            this.rodas = 40;
        } else {
            this.rodas = rodas;
        }
    }

}

class Carro:Veiculo { //classe herdada
    public string nome;
    public string cor;

    public Carro(string nome, string cor):base(4) {
        desligar();
        velMax = 120;
        this.nome = nome;
        this.cor = cor; 
    }
}

class CarroCombate:Carro {
    public int municao;

    public CarroCombate():base("Carro de combate", "verde") {
        municao = 100;
        setRodas(7);
    }
}

class Aula08 {
    static void Main() {
        Carro car1 = new Carro("Rapidao", "Vermelho");
        CarroCombate car2 = new CarroCombate();

        Console.WriteLine("Cor: {0}" ,car1.cor);
        Console.WriteLine("Nome: {0}" ,car1.nome);
        Console.WriteLine("rodas: {0}" ,car1.getRodas());
        Console.WriteLine("VelMax: {0}" ,car1.velMax);
        Console.WriteLine("Ligado: {0}" ,car1.getLigado());

        Console.WriteLine("---------------------------------------------------z ");

        Console.WriteLine("Cor: {0}" ,car2.cor);
        Console.WriteLine("Nome: {0}" ,car2.nome);
        Console.WriteLine("rodas: {0}" ,car2.getRodas());
        Console.WriteLine("VelMax: {0}" ,car2.velMax);
        Console.WriteLine("Ligado: {0}" ,car2.getLigado());
        Console.WriteLine("Municao: {0}" ,car2.municao);
    }
}