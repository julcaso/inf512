/***************************************
Autor:    Profesor Julio Castro Ortiz.
Fecha:    8/5/2021.
Semestre: 2021-10.
Objetivo: Ejemplo docente.
Tema:     Constructores y destructores.
Materias: INF512, INF513.
****************************************/

using System;

class Blusa{
    private string color;
    private int size;
    private string modelo;
    private double precio;

    //Constructores y destructores

    //Constructor por defecto
    public Blusa(){
        Console.WriteLine("\nEsta blusa acaba de ser elaborada en la fabrica");
        color = "negro";
        size = 32;
        modelo = "sin manga";
        precio = 0.0;
    }

    //Constructor con argumentos
    public Blusa(string color, int size, string modelo, double precio){
        Console.WriteLine("\nEste tipo de blusa fue requerido por una tienda y hay que crearla a su gusto");
        this.color = color;
        this.size = size;
        this.modelo = modelo;
        this.precio = precio;
    }
    
    //Destructor
    ~Blusa(){
       Console.WriteLine("\nLa Blusa ha pasado de moda. Será retirada de la colección"); 
    }

    public void desplegarInformacionBlusa(){
        Console.WriteLine("\n*** Informacion de la blusa creada ***\n");
        Console.WriteLine(". Color  : \t\t {0}", color);
        Console.WriteLine(". Tamaño : \t\t {0}", size);
        Console.WriteLine(". Modelo : \t\t {0}", modelo);
        Console.WriteLine(". Precio : \t\t {0}", precio);
        Console.WriteLine("=========================================\n");
    }

    static void Main(){
        Blusa blusa1 = new Blusa();
        blusa1.desplegarInformacionBlusa();
        
        Blusa blusa2 = new Blusa("azul", 28, "clasico", 100.0);
        blusa2.desplegarInformacionBlusa();
    }
}
