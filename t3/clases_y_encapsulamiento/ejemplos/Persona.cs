/*
Autor:    Profesor Julio Castro Ortiz.
Fecha:    22/4/2021.
Objetivo: Ejemplo docente.
Tema:     Encapsulación y constructores.
Materias: INF512, INF513.
*/

using System;

public class Persona{
    public string nombre, colorPelo, colorOjos;
    public int edad;
    public float estatura, peso;
    
    // Constructor sin argumentos.
    // Si no se declara, es añadido por el compilador cuando no existen otros constructores.
    public Persona(){
        nombre = "*********";
        edad = 0;
    }
    
    public Persona(string nombre, string colorPelo){
        this.nombre = nombre;
        this.colorPelo = colorPelo;
    }

    public Persona(string nombre, string colorPelo, string colorOjos){
        this.nombre = nombre;
        this.colorPelo = colorPelo;
        this.colorOjos = colorOjos;
    }

    public void desplegarPersona(){
        Console.WriteLine("\n *** Datos de la persona *** ");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Color de Pelo: " + colorPelo);
        Console.WriteLine("Color de Ojos: " + colorOjos);
    }
}

public class PersonaTest{
        static void Main(){
            Persona myPers1 = new Persona();
            Persona myPers2 = new Persona("Julio Castro", "Negro");
            Persona myPers3 = new Persona("Julio Castro", "Negro", "Negros");

            myPers1.desplegarPersona();
            myPers2.desplegarPersona();
            myPers3.desplegarPersona();

            myPers1.edad=19;
            myPers1.nombre="Reynni";

            myPers1.desplegarPersona();

        }
    }
