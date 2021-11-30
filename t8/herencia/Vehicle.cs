using System;

public class Vehicle{
    private int id;
    private int passengerCapacity;
    public virtual void  acelerar(){
        Console.WriteLine("El vehiculo acelera");
    }
}

public class FueledVehicle : Vehicle{
    private int fuelCapactiy;
    private String fuelType;

    public override void acelerar(){
        base.acelerar();
        Console.WriteLine("El vehiculo fueled acelera");
    }

    public void reducir(){
        Console.WriteLine("El vehiculo redujo velocidad");
    }
}

public class NonFueledVehicle : Vehicle {}

public class Car : FueledVehicle{
    private String description;
}

public class Bycicle : NonFueledVehicle{
    private string description;
}

public class VehicleTest{

    public static void Main(){
        Vehicle myVehicle1 = new Vehicle();
        Vehicle myVehicle2 = new FueledVehicle();
        FueledVehicle myFueled1 = new FueledVehicle();
        myVehicle1.acelerar();   // El vehiculo acelera.
        myVehicle2.acelerar();   // El vehiculo fueled acelera.
        myFueled1.acelerar();    // El vehiculo fueled acelera.

        //Segunda llamada.

        myFueled1.reducir();
        myVehicle2.acelerar();
    }
}
