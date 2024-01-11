using System;

struct Carro {
    public string marca;
    public string cor;

    public void info(){
        Console.WriteLine("Marca: {0}", this.marca);
        Console.WriteLine("Cor: {0}", this.cor);
        Console.WriteLine("---------------------------------------");
    }

    public Carro(string marca, string cor){
        this.marca = marca;
        this.cor = cor;
    }
}

class Aula18 {
    static void Main() {

        Carro[] carros = new Carro[4];

        carros[0].marca = "Mercedes";
        carros[0].cor = "cinzento";

        carros[1].marca = "Lamborghini";
        carros[1].cor = "Branco";

        carros[2].marca = "Porshe";
        carros[2].cor = "Preto";

        carros[3].marca = "Bugatti";
        carros[3].cor = "Vermelho"; 

        for(int i = 0; i < carros.Length; i++){
            carros[i].info();
        }
    }
}