using System;

interface Humano{
    void dormir();
    void respirar();
}

interface HabilidadesDeportivas{
    void jugarBaloncesto(string estilo);
    bool jugarBalonmano();
}

public class Hombre : Humano {
    public void dormir(){
        Console.WriteLine("El ser hombre duerme.");
    }

    public void respirar(){
        Console.WriteLine("El ser hombre respira.");
    }

    public void comer(){
        Console.WriteLine("El ser hombre come.");
    }
}

public class Mujer : Humano, HabilidadesDeportivas {
    public void dormir(){
        Console.WriteLine("La mujer duerme.");
    }

    public void respirar(){
        Console.WriteLine("La mujer respira.");
    }

    public void jugarBaloncesto(string estilo){
        Console.WriteLine("La mujer juega baloncesto, segun el estilo: {0}", estilo);
    }

    public bool jugarBalonmano(){
        return false;
    }
}

public class TesterClass{
    static void Main(){
        Hombre hm = new Hombre();
        hm.dormir();

        Mujer mj = new Mujer();
        mj.dormir();
        mj.jugarBaloncesto("Americano NBA.");
    }
}
