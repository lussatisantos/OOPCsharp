using System;

abstract class Veiculo {
    // Classe base abstrtata

    protected int velMaxima;
    protected int velActual;
    protected bool ligado;

    public Veiculo(){
        ligado = false;
        velActual = 0;
    }

    public void setLigado(bool ligado) {
        this.ligado = ligado;
    }

    public int getVelActual() {
        return velActual;
    }

    abstract public void Aceleracao(int multi);

}

class Carro:Veiculo {

    public Carro(){
        velMaxima = 120;
    }
    override public void Aceleracao(int multi){
        velActual += 10 * multi; 
    }
}

class Aula12 {
    static void Main(){
        Carro carro1 = new Carro();

        carro1.Aceleracao(1);
        carro1.Aceleracao(1);
        Console.WriteLine(carro1.getVelActual());
    }
}