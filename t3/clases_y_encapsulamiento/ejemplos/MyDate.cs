/***************************************************
Autor:    Profesor Julio Castro Ortiz.
Fecha:    25/10/2021.
Semestre: 2021-20.
Objetivo: Ejemplo docente.
Tema:     Implementación de Clases y Encapsulación.
Materias: INF512, INF513.
****************************************************/

using System;

public class MyDate{
    private int day;
    private int month;
    private int year;

    //getters y setters

    public int getDay(){
        return day;
    }

    public void setDay(int day){
        if (day > 31) {
            Console.WriteLine ("Dia invalido");
            this.day = 0;
        }else {
            this.day = day;
        }
    }

    // Metodos generales

    public void verEstado(){
        Console.WriteLine("*** Salida ***");
        Console.WriteLine("Dia: " + day);
        Console.WriteLine("Mes: " + month);
        Console.WriteLine("Anio: " + year);
    }
}

public class MyDateTest{
    static void Main(){
        MyDate miDia = new MyDate();
        miDia.setDay(28);
        //Console.WriteLine("Valor Day: " + miDia.getDay());
        miDia.verEstado();
    }
}
