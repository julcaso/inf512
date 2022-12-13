using System;

abstract class Humano{
    public abstract void comer();
    public abstract void dormir();
    public abstract void hablar();
}

class Persona : Humano{
    public override void comer(){}

    public override void dormir(){}

    public override void hablar(){}
}

class Mujer : Persona{
    public override void hablar(){
        Console.WriteLine("La mujer habla");
    }
}

class Hombre : Persona{
    public override void hablar(){
        Console.WriteLine("El hombre habla");
    }
}

class PolimorfismoTest{
    static void Main(){
        Persona hombre = new Hombre();
        Persona mujer = new Mujer();
        
        hombre.hablar();
        mujer.hablar();
    }
}
