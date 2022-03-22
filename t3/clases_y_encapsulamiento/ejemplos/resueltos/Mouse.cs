using System;

public class Mouse{
    private string marca; //Marcas: Dell, Genius, Logitec, Generic Drive.
    private string modelo;
    private string tipo; //Tipos: Normales, Ergonómicos.
    private string color; //Colores permitidos: Rojo, Verde, Azul.
    private bool ergonomico;
    private float precio;

    public string getMarca(){
        return this.marca;
    }

    public void setMarca(string marca){

        marca = marca.ToUpper();
        
        this.marca = marca;

        if !((marca.Equals("DELL") || marca.Equals("GENIUS") || marca.Equals("LOGITEC"))){
            this.marca = "GENERIC DRIVE";
        } 

    }

    public string getModelo(){
        return this.modelo;
    }

    public void setModelo(string modelo){
        this.modelo = modelo;
    }

    public string getTipo(){
        return this.tipo;
    }

    public void setTipo(string tipo){

        tipo = tipo.ToUpper();
        
        this.tipo = tipo;

        if !(tipo.Equals("NORMALES") && tipo.Equals("ERGONOMICOS")){
            this.tipo="";
            Console.WriteLine("Tipo de Mouse no permitido. Intente con Normales | Ergonomicos");
        }

        if (tipo.Equals("ERGONOMICO")){
            this.ergonomico = true;
        } 

    }

    public bool getErgonomico(){
        return ergonomico;
    }

    public void setErgonomico(bool ergonomico){
        this.ergonomico = ergonomico;
    }

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
        return this.color.ToLower();
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

    public void desplegarInformacion(){
        Console.WriteLine("Marca     : " + getMarca());
        Console.WriteLine("Modelo    : " + getModelo());
        Console.WriteLine("Tipo      : " + getTipo());
        Console.WriteLine("Color     : " + getColor());
        Console.WriteLine("Ergonomico: " + getErgonomico());
        Console.WriteLine("Precio    : " + getPrecio());
    }
}

public class MouseTest{
    static void Main(){
        
        raton1.marca = "Dell";
        raton1.modelo = "WM126";
        raton1.setPrecio(18.99f);
        raton1.setColor("rojo");

        raton1.desplegarInformacion();
    }
}
