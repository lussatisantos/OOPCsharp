using System;

class Galinha{
    private string nomeGalinha;
    private int numOvo;
    public Galinha(string nomeGalinha) { 
        this.nomeGalinha = nomeGalinha;
        numOvo = 0;
    }

    public Ovo botar(){
        numOvo++;
        return new Ovo(numOvo, nomeGalinha);
    }
}

class Ovo {
    private int numOvo;
    private string minhaGalinha;
    public Ovo(int numOvo, string minhaGalinha){
        this.numOvo = numOvo;
        this.minhaGalinha = minhaGalinha;
        Console.WriteLine("Ovo criado: {0} - {1}", this.numOvo, this.minhaGalinha);
    }
}

class Aula20{
    static void Main(){
        Galinha galinha = new Galinha("Benedita");
        Galinha galinha2 = new Galinha("Francisca");
        Galinha galinha1 = new Galinha("Marisa");

        galinha.botar();

        galinha1.botar();

        galinha2.botar();
        galinha2.botar();
        galinha2.botar();


    }
}