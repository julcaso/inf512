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

/* 

Metodos de acceso: getters y setters.

En este espacio defina los metodos get y set que sean necesarios para 
encapsular la clase TelefonoMovil.
  
*/

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
        
        Console.WriteLine("\n*** Salida ***\n");
        Console.WriteLine("Marca:            " + miCelular.marca);
        Console.WriteLine("Color:            " + miCelular.color);
        Console.WriteLine("Modelo:           " + miCelular.modelo);
        Console.WriteLine("Cantidad Camaras: " + miCelular.cantidadCamaras);
        Console.WriteLine("Tamaño:           " + miCelular.size);
        Console.WriteLine("Estado:           " + miCelular.estado);     
    }
}
