using System;

class Jogador{
    private int energia;
    private string nome;

    public Jogador(string nome) {
        this.nome = nome;
        energia = 100;
    }

    public int getEnergia() {
        return energia;
    }

    public string getNome() {
        return nome;
    }

    public void setEnergia(int e) {
        if (e < 0) {
            if (energia-e < 0) {
                energia = 0;
            }
        } else if (e > 0) {
            energia += e;
        }

        if (e > 0) {
            if (energia + e > 100) {
                energia = 100;
            }
        } else if (e < 0) {
            energia += e;
        }
    }
}

class Aula06 {
    static void Main() {
        Jogador J1 = new Jogador("Lussati");

        //J1.setEnergia(-30);
        J1.setEnergia(40000);

        Console.WriteLine("Nome   : {0}", J1.getNome());
        Console.WriteLine("Energia: {0}", J1.getEnergia());
    }
}