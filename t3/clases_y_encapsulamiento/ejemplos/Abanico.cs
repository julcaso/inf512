using System;

//Definicion de clase

class Abanico{

    // miembros encapsulados

    private string marca;
    private string color;
    private double precio;
    private int cantidadVelocidades;

    //miembros public o interfaz de la clase

    public void setCantidadVelocidades(int cv){
        if (cv <= 4){
            cantidadVelocidades = cv;
        } else {
            cantidadVelocidades = 0;
            Console.WriteLine("Error #512.01 Valor Invalido");
        }
    }

    public int getCantidadVelocidades(){
        return cantidadVelocidades;
    }

    public void abanicar(){
        Console.WriteLine("\n\t => Y estoy echando fresco, buuuuuuuuu");
    }

    public void setEstado(string marca, string color, double p){
        this.marca = marca;
        this.color = color;
        precio = p;
    }

    public void verEstado(){
        Console.WriteLine("\n\t => El abanico actual tiene el siguiente estado \n");
        Console.WriteLine("\t => Marca: {0} \n\t Color: {1} \n\t Precio: {2}", marca, color, precio);     
    }

}

class AbanicoTester{

    static void Main(){
        
        Abanico miAbanico1 = new Abanico();
       
        Abanico miAbanico2 = new Abanico();

        //miAbanico1.verEstado();
        miAbanico1.setEstado("KDK", "Blanco",1345.56);
        miAbanico1.verEstado();
        miAbanico1.abanicar();

        miAbanico2.setEstado("Samsung", "Rojo",10000);
        miAbanico2.verEstado();
        miAbanico2.abanicar();

        //miAbanico1.cantidadVelocidades=3567;
        miAbanico1.setCantidadVelocidades(3);

        Console.WriteLine("Cantidad Velocidades: " + miAbanico1.getCantidadVelocidades());
    }
}
