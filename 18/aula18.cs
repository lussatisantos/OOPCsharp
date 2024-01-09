using System;

struct Carro {
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca, string modelo, string cor){
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }
}

class Aula18 {
    static void Main() {

        Carro carro;

        Carro carro1 = new Carro("Lamborghini", "F17", "Branco");

        carro.marca = "Mercedes Benz";
        carro.modelo = "Golf";
        carro.cor = "Cinzento";

        Console.WriteLine("////////////////////////////////");

        Console.WriteLine("Marca: {0}",carro.marca);
        Console.WriteLine("Modelo: {0}",carro.modelo);
        Console.WriteLine("Cor: {0}",carro.cor);

        Console.WriteLine("////////////////////////////////");

        Console.WriteLine("Marca: {0}",carro1.marca);
        Console.WriteLine("Modelo: {0}",carro1.modelo);
        Console.WriteLine("Cor: {0}",carro1.cor);

        Console.WriteLine("////////////////////////////////");
    }
}