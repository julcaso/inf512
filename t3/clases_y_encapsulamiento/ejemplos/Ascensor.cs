/***************************************
Autor:    Profesor Julio Castro Ortiz.
Fecha:    22/4/2021
Semestre: 2021-10
Objetivo: Ejemplo docente.
Tema:     Encapsulación y constructores.
Materias: INF512, INF513.
****************************************/

using System;

class Ascensor{
    private int maximoPisos=5;

    public void setMaximoPisos(int parametro){
        if (parametro > maximoPisos){
            Console.WriteLine("Numero de pisos invalido");
        }
        else{
            maximoPisos = parametro;
        }
    }

    public int getMaximoPisos(){
        return maximoPisos;
    }
}

class AscensorTest{
    static void Main(){
        Ascensor myAscensor = new Ascensor();
        Console.WriteLine("El numero de pisos del ascensor es: "  + myAscensor.getMaximoPisos());
        myAscensor.setMaximoPisos(58);
    }
}

