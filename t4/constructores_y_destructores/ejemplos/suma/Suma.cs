/***************************************
Autor:    Profesor Julio Castro Ortiz.
Fecha:    3/28/2022.
Semestre: 2021-20.
Objetivo: Ejemplo docente.
Tema:     Constructores y destructores.
Materias: INF512, INF513.
****************************************/

using System;

class Suma{

    int val1, val2;
    float val3, val4;

    public Suma(){
        val1 = 5;
        val2 = 5;
        Console.WriteLine("La suma por default es: {0} ", val1 + val2);
    }

    public Suma(int parVal1, int parVal2){
        val1 = parVal1;
        val2 = parVal2;
        Console.WriteLine("La suma entera es: {0} ", val1 + val2);
    }

    public Suma(float val3, float val4){
        this.val3 = val3;
        this.val4 = val4;
        Console.WriteLine("La suma flotante es: {0} ", this.val3 + this.val4);

    }

    ~Suma(){
        Console.WriteLine("El programa terminó.");
        Console.WriteLine("Los objetos fueron eliminados de la memoria.");
    }

    //ALT + 126 = ~
}

class SumaTest{
    static void Main(){
        
        Suma sm1 = new Suma();
        Suma sm2 = new Suma(56, 78);
        Suma sm3 = new Suma(68.0f, 85.4f);

        //Eliminando la referencia del objeto Suma en la variable 
        //de referencia a objetos sm1.
        sm1 = null;       
    }
}
