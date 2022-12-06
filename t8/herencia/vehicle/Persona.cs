using System;

abstract class Persona{
    private int edad;
    private string nombre;
    private string apellido;
    private string genero;

    public Persona(){}

    Public Persona(string genero){
        this.genero=genero;
    }

    public Persona(int edad, string nombre, string apellido, string genero){
        this.edad = edad;
        this.nombre = nombre;
        this.apellido = apellido;
        this.genero = genero;
    }
    
    public abstract string unirNombreApellido(string nombre, string apellido);

    public int getEdad(){
        return edad;
    }

    public void setEdad(int edad){
        this.edad = edad;
    }

    public string getNombre(){
        return nombre;
    }

    public void setNombre(string nombre){
        this.nombre = nombre;
    }

    public string getApellido(){
        return apellido;
    }

    public void setApellido(string apellido){
        this.apellido = apellido;
    }

}

class Hombre : Persona {

    public Hombre(){
        base("M");
    }

    public override string unirNombreApellido(string nombre, string apellido){
        return nombre + " " + apellido;
    }
}
