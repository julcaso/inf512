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

/* 
Atributos de clase.
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
    
    //Constructor por defecto
    public TelefonoMovil(){
        marca = "iPhone";
        color = "Negro";
        modelo = "13";
        cantidadCamaras = 10;
        size = 7;
        estado = "apagado";        
    }
    
    //Constructor con argumentos
    public TelefonoMovil(string marca, string color){
        this.marca = marca;
        this.color = color;
    }

/* 
Metodos de acceso: getters y setters.
En este espacio defina los metodos get y set que sean necesarios para 
encapsular la clase TelefonoMovil.
*/

    public void desplegarTelefonoMovil(){
        Console.WriteLine("\n*** Salida ***\n");
        Console.WriteLine("Marca:            " + marca);
        Console.WriteLine("Color:            " + color);
        Console.WriteLine("Modelo:           " + modelo);
        Console.WriteLine("Cantidad Camaras: " + cantidadCamaras);
        Console.WriteLine("Tamaño:           " + size);
        Console.WriteLine("Estado:           " + estado);
    }

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

}

class TelefonoMovilTest{
    public static void Main(){
        
        TelefonoMovil miCelular = new TelefonoMovil();
      
        miCelular.marca = "Samsung";
        miCelular.color = "Negro";
        miCelular.modelo = "A50";
        miCelular.cantidadCamaras = 1000;
        miCelular.size = 6;
        miCelular.estado = "Sumergido en agua";
        
        miCelular.desplegarTelefonoMovil();

        TelefonoMovil miCelular2 = new TelefonoMovil();
        miCelular2.desplegarTelefonoMovil();        

        TelefonoMovil miCelular3 = new TelefonoMovil("Xaomi", "Blanco");
        miCelular3.desplegarTelefonoMovil();

    }
}
