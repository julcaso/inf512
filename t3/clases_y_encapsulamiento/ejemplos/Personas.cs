using System;

class Personas{
	private string nombre;
	private string apellido;
	private string genero;
	private int edad;
	
	public Personas(){
		setNombre("Victor");
		setApellido("Ortiz");
		setGenero("M");
		setEdad(58);
	}
	
	public Personas(string nombre, string apellido, string genero, int edad){
		this.nombre = nombre;
		this.apellido = apellido;
		setGenero(genero);
		setEdad(edad);
	}
	
	public void setNombre(string nombre){
		this.nombre  = nombre;		
	}
	
	public string getNombre(){
		return nombre;
	}
	
	public void setApellido(string apellido){
		this.apellido = apellido; 
	}
	
	public string getApellido(){
		return apellido;
	}
	
	public void setEdad(int argumentoEdad){
		if (argumentoEdad >=0 && argumentoEdad <= 150){
			edad = argumentoEdad;
		} else {
			Console.WriteLine("La edad debe estar entre 0 y 150. ");
			edad = 0;
		}
	}
	
	public int getEdad(){
		return edad;
	}
	
	public void setGenero(string genero){
		if (genero.ToUpper().Equals("M") || genero.ToUpper().Equals("F")){
			this.genero = genero;
		} else {
			Console.WriteLine("El genero es masculino (m) o femenino (f)");
		}
	}
	
	public string getGenero(){
		return genero;
	}

	public void displayScreen(){
		Console.WriteLine("Nombre: " + nombre);
		Console.WriteLine("Apellido: {0}", apellido);
		Console.WriteLine("Sexo: {0} Edad: {1} \n", genero, edad);
	}
}

class PersonaTest{
	static void Main(){
		Personas p1 = new Personas();
		p1.displayScreen();
		
		Personas p2 = new Personas();
		p2.displayScreen();
		
		Personas p3 = new Personas("Maridalia", "Hernandez", "F", 65);
		p3.displayScreen();
	}
	
}