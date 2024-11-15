using System;

class Carro{
	private string marca;
	private string color;
	private double precio;
	private string radio;
	
	public Carro(){
		Console.Write("Marca: \t");
		marca = Console.ReadLine();
		
		Console.Write("Color: \t");
		color = Console.ReadLine();	
	}
	
	public void setRadio(string radio){
		this.radio = radio;
	}
	
	public void setPrecio(double precio){
		this.precio = precio + (precio * 0.15);
	}
	
	public double getPrecio(){
		return precio;
	}
	
	public void verCarro(){
		//Muestra por stdout el estado de un objeto.
		Console.WriteLine("MARCA  = {0}", marca);
		Console.WriteLine("COLOR  = {0}", color);
		Console.WriteLine("PRECIO = {0}", precio);
		Console.WriteLine("RADIO = {0}", radio);
	}
}

class CarroTest{
	static void Main(){
		
		double precioCarro;
		string conforme = "n";
		
		while (conforme.ToUpper().equals("NO") && !conforme.ToUpper.equals("SI"){
			Console.WriteLine ("\nDigame los Datos que Usted Quiere: ");
			Carro miCarro = new Carro();
			
			Console.Write("Precio: \t");
			precioCarro = Double.parse(Console.ReadLine());
			miCarro.setPrecio(precioCarro);
			
			Console.WriteLine("Un carro por defecto disponible");
			
			Console.WriteLine("El precio que le puedo dar es: {0}", miCarro.getPrecio());
			
			Console.WriteLine("\nConforme?, si Si: ");
			conforme = Console.ReadLine();
		}
		
		Console.WriteLine("\nOK. Este es el carro que usted va a comprar");
		miCarro.setRadio("2X7 inch, Stereo Car DVD Player Bluetooth Radio iPod SD-USB");
		miCarro.verCarro();
		Console.WriteLine("\n\t\tGracias por su compra.");
	}
}
