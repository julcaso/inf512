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

