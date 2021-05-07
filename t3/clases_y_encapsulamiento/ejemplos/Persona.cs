/***************************************
Autor:    Profesor Julio Castro Ortiz.
Fecha:    22/4/2021.
Semestre: 2021-10.
Objetivo: Ejemplo docente.
Tema:     Encapsulación y constructores.
Materias: INF512, INF513.
****************************************/

using System;

public class Persona{
    
    //Variables de instancia.
    
    private string nombre, colorPelo, colorOjos;
    private int edad;
    private float estatura, peso;

    //Variable estatica: ejemplo.
    private static int contadorObjetos;

    public static int getContadorObjetos(){
        return contadorObjetos;
    }

    public void setEdad(int edad){
        if (edad > 125){
            Console.WriteLine("Esta edad no es valida.");
        } else {
            this.edad = edad;
        }
    }

    public int getEdad(){
        return edad;
    }

    // Constructor sin argumentos.
    // Si no se declara, es añadido por el compilador cuando no existen otros constructores.
    public Persona(){
        nombre = "*********";
        edad = 0;
        contadorObjetos++;
    }
    
    public Persona(string nombre, string colorPelo){
        this.nombre = nombre;
        this.colorPelo = colorPelo;
        contadorObjetos++;
    }

    public Persona(string nombre, string colorPelo, string colorOjos){
        this.nombre = nombre;
        this.colorPelo = colorPelo;
        this.colorOjos = colorOjos;
        contadorObjetos++;
    }

    public void desplegarPersona(){
        Console.WriteLine("\n *** Datos de la persona *** ");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Color de Pelo: " + colorPelo);
        Console.WriteLine("Color de Ojos: " + colorOjos);
        Console.WriteLine("Edad         : " + edad);
    }
}

public class PersonaTest{
    static void Main(){
        Persona myPers1 = new Persona();
        Persona myPers2 = new Persona("Yovainy Rodriguez", "Negro");
        Persona myPers3 = new Persona("Omar Arias", "Negro", "Negros");
        Persona myPers4 = new Persona("Jessica Rodriguez","Negro","Marrones");

        myPers4.setEdad(35);
        Console.WriteLine("Valor de edad: " + myPers4.getEdad());
           
        myPers1.desplegarPersona();
        myPers2.desplegarPersona();
        myPers3.desplegarPersona();
        myPers4.desplegarPersona();
        
        // Haciendo que se pierda la referencia de la variable al objeto.
        myPers4 = null;

        // Haciendo uso de un método estático.
        Console.WriteLine("Cantidad de objetos instanciados: {0}", Persona.getContadorObjetos());
        
    }
}
