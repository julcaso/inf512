/***************************************
Autor:    Profesor Julio Castro Ortiz.
Fecha:    11/8/2021.
Semestre: 2021-20.
Objetivo: Ejemplo docente.
Tema:     Constructores y destructores.
Materias: INF512, INF513.
****************************************/

using System;
class TelefonoMovil{

    /* Atributos de clase, tambien llamados atributos de instancia.
    Debajo se encuentran las definiciones de los atributos de la clase TelefonoMovil.
    Realice los cambios en los atributos y metodos que sean necesarios para encapsular
    la clase TelefonoMovil.
    */
    
    public string marca;
    public string color;
    public string modelo;
    public int cantidadCamaras;
    public int size;
    public string estado;
    
    /* Constructores y destructores */

    //Constructor por defecto
    public TelefonoMovil(){
        Console.WriteLine("Constructor sin argumentos. Tambien llamado constructor por defecto");
        marca = "iPhone";
        color = "Negro";
        modelo = "13";
        cantidadCamaras = 10;
        size = 7;
        estado = "apagado";        
    }
    
    //Constructor con argumentos
    public TelefonoMovil(string marca, string color){
        Console.WriteLine("Constructor con argumentos.");
        this.marca = marca;
        this.color = color;
    }

    //Destructor
    ~TelefonoMovil(){
        Console.WriteLine("Se invoca cuando se destruye el objeto");
    }
    
    /* Métodos de acceso: getters y setters.
    En este espacio defina los metodos get y set que sean necesarios para
    encapsular la clase TelefonoMovil.
    */

    
    /* Métodos de clase, tambien llamados métodos de instancia.*/

    public bool marcar(){
        return true;
    }

    public bool llamar(string numeroTelefonoDestino){
        return true;
    }

    public void vibrar(){
    }

    public bool encender(){
        return true;
    }

    public bool apagar(){
        return true;
    }

    public void desplegarInformacion(){
        Console.WriteLine("\n*** Salida ***\n");
        Console.WriteLine("Marca:            " + marca);
        Console.WriteLine("Color:            " + color);
        Console.WriteLine("Modelo:           " + modelo);
        Console.WriteLine("Cantidad Camaras: " + cantidadCamaras);
        Console.WriteLine("Tamaño:           " + size);
        Console.WriteLine("Estado:           " + estado + "\n");
    }

}

/* Clase de prueba, tambien llamada Tester Class. Es la que contiene el metodo main. */

class TelefonoMovilTest{
    public static void Main(){
        
        TelefonoMovil miCelular1 = new TelefonoMovil();

        miCelular1.marca = "Samsung";
        miCelular1.color = "Negro";
        miCelular1.modelo = "A50";
        miCelular1.cantidadCamaras = 1000;
        miCelular1.size = 6;
        miCelular1.estado = "Sumergido en agua";
        
        miCelular1.desplegarInformacion();

        TelefonoMovil miCelular2 = new TelefonoMovil();
        miCelular2.desplegarInformacion();

        TelefonoMovil miCelular3 = new TelefonoMovil("Xaomi", "Blanco");
        miCelular3.desplegarInformacion();

    }
}
