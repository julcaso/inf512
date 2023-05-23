/***************************************
Autor:    Profesor Julio Castro Ortiz.
Fecha:    22/5/2023
Semestre: 2023-10
Objetivo: Ejemplo docente.
Tema:     Polimorfismo.
Materias: INF512, INF513.
****************************************/

using System;

public abstract class Animal{
    protected int legs;
    
    public Animal(int legs){
        this.legs = legs;
    }

    public virtual void walk(){
        Console.WriteLine("El animal camina.");
    }

    public abstract void eat();
}

public interface Pet{
    string getName();
    void setName(string n);
    void play();
}

public class Spider : Animal {
    public Spider() : base(6) {;
    }

    public override void eat(){
        Console.WriteLine("La araña come.");        
    }
}

public class Cat : Animal, Pet{
    private string name;
    
    public Cat(string n) : base(4) {;
        name = n;
    }

    public Cat() : base(4) {;
        name = "Heathcliff";
    }

    public string getName(){
        return name;
    }

    public void setName(string n){
        name = n;
    }

    public void play(){
        Console.WriteLine("El gato juega");
    }

    public override void eat(){
        Console.WriteLine("El gato come.");        
    }
}


public class Fish : Animal, Pet{
    private string name;
    
    public Fish() : base(0) {}

    public string getName(){
        return name;
    }

    public void setName(string n){
        name = n;
    }

    public void play(){
        Console.WriteLine("El pescado juega");
    }

    public override void walk(){
        Console.WriteLine("El pescado nada.");
    }

    public override void eat(){
        Console.WriteLine("El pescado come.");        
    }
}

public class AnimalTest{
    static void Main(){

        Pet mascota;

        mascota = new Cat("Heathcliff");
        mascota.play();
        
        mascota = new Fish();
        mascota.play();

        Animal unAnimal;

        unAnimal = new Cat();
        unAnimal.eat();

        unAnimal = new Spider();
        unAnimal.eat();

        unAnimal = new Fish();
        unAnimal.eat();

    }
}






