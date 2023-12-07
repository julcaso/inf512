using System;
class Computadora{
    private string modelo;
    private float precio;
    
    public Computadora(){}

    public Computadora(string modelo, float precio){
        this.modelo = modelo;
        this.precio = precio;
    }
}

class Persona{
    private int edad;
    private string nombre, apellido;
    Computadora comp;

    public Persona{}

    public void asociarComputadora(string modelo, float precio){
        comp = new Computadora(modelo, precio);
    }
}

class PersonaTest{
    static void Main(){
        Persona p1 = new Persona();
        p1.asociarComputadora("DELL LATITUDE E750", 1600.0f);
    }
}
