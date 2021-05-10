/*****************************************************
Autor:    Profesor Julio Castro Ortiz.
Fecha:    10/5/2021.
Semestre: 2021-10.
Objetivo: Ejemplo docente.
Tema:     Implementación de clases y encapsulamiento.
Materias: INF512, INF513.
******************************************************/

using System;

public class Libro{
    private int numeroPaginas;
    private string autor;
    private string casaEditora;

    public Libro(){
        numeroPaginas = 50;
    }

    public Libro(int numeroPaginas){
        this.numeroPaginas = numeroPaginas;
    }

    public string getAutor(){
        return autor;
    }

    public void setAutor(string autor){
        this.autor=autor;
    }

    public void setNumeroPaginas(int numeroPaginas){
        if (numeroPaginas > 0){
            this.numeroPaginas = numeroPaginas;
        } else {
            Console.WriteLine("Numero de paginas invalido.");            
        }
    }

    public void setVariables(int numeroPaginas, string autor, string casaEditora){
        setNumeroPaginas(numeroPaginas);        
        this.autor = autor;
        this.casaEditora = casaEditora;

    //Por favor cree un metodo desplegarInfo para que muestre la informacion de la instancia de libro.

    }
}

public class LibroTest{
    public static void Main(){
        
        Libro miLibro1 = new Libro();
        miLibro1.setAutor("Julio Castro");
        miLibro1.setNumeroPaginas(400);
        
        Libro miLibro2 = new Libro(5000);
    }
}
