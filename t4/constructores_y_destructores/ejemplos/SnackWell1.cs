/**
 Autor      : Estudiante Fidel Ernesto Reyes Urbaez.
 Fecha      : 27/12/2020.  
 Tema       : Constructores y Destructores.
 Descripción: Maquina expendedora Snackwell.
**/

using System;
using System.Threading;

class MaquinaExpendedora
{
    private int monto;
    private int moneda;
    private int precio;
    private string productos;

    public MaquinaExpendedora() 
    {
        monto = 35;
        
    }

    public int getMonto()
    {
        return monto;
    }

    public void aumentarMonto(int moneda)
    {
        monto = monto+ moneda;

        
    }

    public void disminuirMonto(int precio)
    {
        monto -= precio;
    }

    public void setMoneda(int moneda)
    {
        switch (moneda)
        {
            
            case 1:
            this.moneda = moneda;
            break;

            case 5:
            this.moneda = moneda;
            break;

            case 10:
            this.moneda = moneda;
            break;

            case 25:
            this.moneda = moneda;
            break;
            
            default:

            Console.WriteLine("¡Moneda Invalida!");

            break;
        }
    }

    public int getMoneda()
    {
        return moneda;
    }

    public void setPrecio(int precio)
    {
        switch(precio)
        {
            case 30:
            this.precio = precio;
            break;

            case 35:
            this.precio = precio;
            break;

            case 60:
            this.precio = precio;
            break;

            case 25:
            this.precio = precio;
            break;
            
            default:
            Console.WriteLine("¡Precio Invalido!");
            break;
        }
    }

    public int getPrecio()
    {
        return precio;
    }

    public void setProductos(string productos)
    {
        switch (productos)
        {
            case "Platanitos":
            this.productos = productos;
            break;

            case "Yuquitas":
            this.productos = productos;
            break;

            case "MyM":
            this.productos = productos;
            break;

            case "Mas Mas":
            this.productos = productos;
            break;

            default:
            Console.WriteLine("¡Producto Invalido!");
            break;
        }
    }

    public string getProductos()
    {
        return productos;
    }
}

class MaquinaExpendedoraTest
{
    static void Main(string[] args)
    {
        MaquinaExpendedora[] tuProductos = new MaquinaExpendedora[4];

        int seleccion;
        do
        {
        for(int i = 0; i<4; i++)
        {
            tuProductos[i] = new MaquinaExpendedora();
        }

        tuProductos[0].setMoneda(10);
        tuProductos[1].setMoneda(25);
        

        tuProductos[0].setPrecio(30);
        tuProductos[0].setProductos("Platanitos");

        tuProductos[1].setPrecio(35);
        tuProductos[1].setProductos("Yuquitas");

        tuProductos[2].setPrecio(60);
        tuProductos[2].setProductos("MyM");

        tuProductos[3].setPrecio(25);
        tuProductos[3].setProductos("Mas Mas");

        do
        {
        Console.WriteLine("\n\nMáquina Expendedora ");
        Console.WriteLine("\nMonto Disponible: RD${0}",tuProductos[0].getMonto()+"\n");

        Console.WriteLine("{0,-15:D} {1}","Tipo de Producto","Precio"+"\n");
        for(int i = 0; i<4; i++)
        {
            Console.WriteLine("[{0}] {1,-16:D} RD${2}",i+1,tuProductos[i].getProductos(),tuProductos[i].getPrecio());
        }

        Console.WriteLine("\n[5] Insertar Moneda");
        Console.WriteLine("[6] Reiniciar");
        Console.WriteLine("[7] Apagar");
        Console.WriteLine("Los botones del [1] al [4] son para eligir el Producto que desee");
        do
        {
        Console.WriteLine("Seleccione lo que quiere hacer");
        seleccion = int.Parse(Console.ReadLine());

        if(seleccion > 7 || seleccion < 1)
        {
            Console.WriteLine("Introduzca un valor válido");
        }

        }while(seleccion > 7 || seleccion < 1);

        if(seleccion >= 1 && seleccion <= 4)
        {
            if(tuProductos[0].getMonto() >= tuProductos[seleccion - 1].getPrecio())
            {
                tuProductos[0].disminuirMonto(tuProductos[seleccion - 1].getPrecio());
                Console.Write("Entregando su "+tuProductos[seleccion - 1].getProductos());

                for(int i = 0; i < 4;i++)
                {
                Thread.Sleep(1000);
                Console.Write(".");
                }

                Console.WriteLine("\nSu "+tuProductos[seleccion - 1].getProductos()+" Puede tomas su Producto");
                Console.WriteLine("Presione cualquier botón para continuar\n");
                Console.ReadKey();
            }else
            {
                Console.WriteLine("Monto Disponible Insuficiente");
                Console.WriteLine("Inserte una moneda o seleccione otro producto ");
                Console.WriteLine("Presione cualquier botón para continuar\n");
                Console.ReadKey();
            }
        }

        if(seleccion == 5)
        {
            Console.WriteLine("Insertar Moneda\n");
            for(int i = 0; i<2; i++)
            {
            Console.WriteLine("[{0}] RD${1}",i+1,tuProductos[i].getMoneda());
            }

            do
            {
            Console.WriteLine("Seleccione la Moneda que quiera insertar");
            seleccion = int.Parse(Console.ReadLine());

            if(seleccion > 4 || seleccion < 1)
            {
                Console.WriteLine("Introduzca un valor válido");
            }

            }while(seleccion > 4 || seleccion < 1);

            Console.Write("Insertando moneda de RD$"+tuProductos[seleccion - 1].getMoneda());

            for(int i = 0; i < 3;i++)
            {
            Thread.Sleep(1000);
            Console.Write(".");
            }
            tuProductos[0].aumentarMonto(tuProductos[seleccion - 1].getMoneda());
            Console.WriteLine("\nMoneda de RD$"+tuProductos[seleccion - 1].getMoneda()+" insertada");
            Console.WriteLine("Presione cualquier botón para continuar\n");
            Console.ReadKey();
        }

        }while(seleccion != 6 && seleccion != 7);

        if(seleccion == 6)
        {
            Console.Write("Reiniciando");

            for(int i = 0; i < 3;i++)
            {
            Thread.Sleep(1000);
            Console.Write(".");
            }

            Console.Write("\nMáquina Reiniciada");
        }

        }while(seleccion != 7);

        Console.Write("Apagando");

        for(int i = 0; i < 3;i++)
        {
        Thread.Sleep(1000);
        Console.Write(".");
        }

        Console.WriteLine("\nMáquina Apagada");
        

    }

}
