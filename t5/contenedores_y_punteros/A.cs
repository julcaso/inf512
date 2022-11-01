using System;

class A{

	private double x;
	
	public A(){
		x = 0.001;
	}
	
	public A(double z){
		x = z;
	}
	
	public void setX(double w){
		x = w;
	}
	
	public double getX(){
		return x;
	}
	
	public static void verObjetos(Object [] ao) {
		
		//Este metodo es para ver los objetos almacenados en el arreglo.
		
		//Recorriendo el arreglo con un foreach.
		
		foreach (Object element in ao){
			if (element != null){
				Console.WriteLine(element.ToString()); //ToString Devuelve una cadena que representa el objeto actual.
				Console.WriteLine(element.GetType()); //GetType retorna el tipo de dato almacenado en el elemento.
				Console.WriteLine("-----------------");
			}
		}
	}
} // fin de la clase A.

class Tester{
	public static void Main(){
		
		// Declaracion del objeto.
		
		Object [] arrObj = new Object[5];
		
		//Incializar los valores del arreglo contenedor.
		
		arrObj[0] = new A(98456);
		arrObj[1] = 6.67;
		arrObj[2] = "Hola, arreglos de objetos en C#";
		arrObj[3] = new Object();
		
		//ver informacion de los objetos
		
		A.verObjetos(arrObj);
		
	}
}
