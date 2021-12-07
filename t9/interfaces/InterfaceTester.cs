using System;

interface IAnimal{
    void getAnimal();
    void setAnimal(string nombre);
}

interface IBipedo{
    void setNumeroPatas(int numero);
}

interface IAnimalBipedo : IAnimal, IBipedo{

}

class Dinosaurio : IAnimal, IBipedo{
    public void getAnimal(){
        Console.WriteLine("\n\tSoy un Tiranosaurio Rex, como el de Jurassic Park");
    }

    public void setAnimal(string nombre){
        Console.WriteLine("Nombre del Dinosaurio: " + nombre);
    }

    public void setNumeroPatas(int numero){
        Console.WriteLine("Numero de patas: " + numero);
    }
}

class Microorganismo : IAnimal{
    public void getAnimal(){
        Console.WriteLine("\n\tSoy un Animal con una sola capa de celulas");
    }

    public void setAnimal(string nombre){
        Console.WriteLine("Nombre del Microorganismo: " + nombre);
    }
}

class Perro : IAnimalBipedo{
    public void getAnimal(){
        Console.WriteLine("\n\tSoy un Perro Boby.");
    }

    public void setAnimal(string nombre){
        Console.WriteLine("Nombre del Perro: " + nombre);
    }

    public void setNumeroPatas(int numero){
        Console.WriteLine("Numero de patas: " + numero);
    }
}

//Tester class

class InterfaceTester{
    static void Main(){
        new Dinosaurio().getAnimal();
        new Dinosaurio().setAnimal("Rex");
        new Dinosaurio().setNumeroPatas(5);

        new Microorganismo().getAnimal();
        new Microorganismo().setAnimal("Jibaro");

        new Perro().getAnimal();
    }
}
