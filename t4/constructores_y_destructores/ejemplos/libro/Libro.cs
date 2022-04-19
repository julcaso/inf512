/*****************************************************
Autor:    Profesor Julio Castro Ortiz.
Fecha:    18/4/2022.
Semestre: 2022-10.
Objetivo: Ejemplo docente.
Tema:     Constructores y destructores.
Materias: INF512, INF513.
******************************************************/

using System;

public class Libro{
    private int numeroPaginas;
    private string autor;
    private string casaEditora;

    public Libro(){
        setNumeroPaginas(100);
        autor = "Julio Castro";
        casaEditora = "Editora MJ";
    }

    public Libro(int numeroPaginas){
        setNumeroPaginas(numeroPaginas);
    }

    public Libro(string autor){
        this.autor = autor;
    }

    public Libro(int numeroPaginas, string casaEditora){
        setNumeroPaginas(numeroPaginas);
        this.casaEditora = casaEditora;
    }

    public Libro(int numeroPaginas, string casaEditora, string autor){
        setNumeroPaginas(numeroPaginas);
        this.casaEditora = casaEditora;
        this.autor = autor;
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
    }

    public void desplegarInformacion(){
        Console.WriteLine("Autor: {0}, Casa Editora: {1}, Numero de Paginas: {2}", autor, casaEditora, numeroPaginas);
    }

    ~Libro(){
        Console.WriteLine("Cerrando / destruyendo objetos.");
        autor = null;
        casaEditora = null;
        numeroPaginas = 0;
        Console.WriteLine("Valores restaurados a su estado orignal.");
    }
}

public class LibroTest{
    public static void Main(){
        
        Libro miLibro1 = new Libro();
        miLibro1.desplegarInformacion();

        Libro miLibro2 = new Libro(3);
        miLibro2.setAutor("Julio Ortiz");
        miLibro2.desplegarInformacion();

        Libro miLibro3 = new Libro(35, "Editora de Formas");
        miLibro3.desplegarInformacion();

        Libro miLibro4 = new Libro(1000, "Grecia", "Homero");
        miLibro4.desplegarInformacion();
         
        Console.ReadLine();
        
    }
}
