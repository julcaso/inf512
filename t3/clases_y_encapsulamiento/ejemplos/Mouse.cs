using System;

public class Mouse{
    public string marca;
    public string modelo;
    public string tipo;
    private string color; //Colores permitidos: Rojo, Verde, Azul.
    public bool ergonomico;
    private float precio;

    public bool seleccionar(string bloqueTexto){
        return true;
    }

    public bool clickDerecho(){
        Console.WriteLine("El usuario ha hecho un click derecho");
        return true;
    }

    public bool clickIzquierdo(){
        Console.WriteLine("El usuario ha hecho un click izquierdo");
        return true;
    }

    public string arrastrar(string bloqueTexto){
        return "";
    }

    public void setPrecio(float precio){
        if (precio >= 0.0 && precio <=50.0){
            this.precio = precio;
        } else {
            this.precio = 0.0f;
            Console.WriteLine("Error 1. Precio Invalido.");
        }
    }

    public float getPrecio(){
        return this.precio;
    }

    public string getColor(){
        return this.color;
    }

    public void setColor(string color){
        color = color.ToUpper();
        if (color.Equals("ROJO") || color.Equals("VERDE") || color.Equals("AZUL")){
            this.color = color;
        } else {
            Console.WriteLine("Error 2. Color Invalido.");
            Console.WriteLine("Colores permitidos: ROJO, VERDE, AZUL.");
            Console.WriteLine("Debe corregir color: " + color);
            this.color = null;
        }
    }
}

public class MouseTest{
    static void Main(){
        Mouse raton1 = new Mouse();

        raton1.marca = "Dell";
        raton1.modelo = "WM126";
        raton1.setPrecio(18.99f);
        raton1.setColor("rojo");

        Console.WriteLine("¿Que color seteaste? " + raton1.getColor());
    }
}
