using System;

namespace MDP1
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//Ejercicio 6
			
			/*
			Coleccionable coleccionable = new Conjunto();
			FabricaDeComparables fabrica = new FabricaDeAlumnos();

			llenar(coleccionable, fabrica, 1);
			informar(coleccionable, 1);
			*/
			
			//Ejercicio 9
			
			Coleccionable coleccionable = new Conjunto();
			FabricaDeComparables fabrica = new FabricaDeProfesores();

			llenar(coleccionable, fabrica, 1);
			informar(coleccionable, 1);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		//Ejercicio 6
		
		/*
		public static void llenar(Coleccionable coleccionable, FabricaDeComparables fabrica, int opcion)
		{
			for (int i = 0; i < 20; i++) {
				Comparable comparable = fabrica.crearAleatorio(opcion);
				coleccionable.agregar(comparable);
			}
		}
		*/

		public static void llenarAlumnos(Coleccionable coleccionable)
		{
			Random rnd = new Random();

			for (int i = 0; i < 20; i++) {
				string nombre = "Alumno" + (rnd.Next(1, 100)).ToString();
				int dni = rnd.Next(10000000, 99999999);
				int legajo = rnd.Next(1000, 2000);
				double promedio = rnd.NextDouble() * 10;
				Alumno alumno = new Alumno(nombre, dni, legajo, promedio);
				CompararDni estrategia = new CompararDni();
				alumno.setEstrategiaComparacion(estrategia);
				coleccionable.agregar(alumno);
			}
		}
	
		//Ejercicio 6
		
		/*
		public static void informar(Coleccionable coleccionable, int opcion)
		{
			Console.WriteLine("Opción: " + opcion);
			Console.WriteLine("Cantidad de elementos en la colección: " + coleccionable.cuantos());
			Console.WriteLine("Mínimo elemento en la colección: " + coleccionable.minimo());
			Console.WriteLine("Máximo elemento en la colección: " + coleccionable.maximo());
		}
		*/
		
		public static void imprimirElementos(Iterable coleccionable)
		{
			Iterador iterador = coleccionable.crearIterador();

			iterador.primero();
			while (!iterador.fin()) {
				Iterado elemento = iterador.actual();
				Console.WriteLine(elemento);
				iterador.siguiente();
			}
		}
		
		public static void cambiarEstrategia(Iterable coleccionable, CompararEstrategia estrategia)
		{
			Iterador iterador = coleccionable.crearIterador();

			iterador.primero();
			while (!iterador.fin()) {
				Alumno alumno = (Alumno)iterador.actual();
				alumno.setEstrategiaComparacion(estrategia);
				iterador.siguiente();
			}
		}
		
		//Ejercicio 9
		
		public static void llenar(Coleccionable coleccionable, FabricaDeComparables fabrica, int opcion)
		{
			for (int i = 0; i < 20; i++) {
				Comparable comparable = fabrica.crearAleatorio(opcion);
				coleccionable.agregar(comparable);
			}
		}

		public static void informar(Coleccionable coleccionable, int opcion)
		{
			Console.WriteLine("Opción: " + opcion);
			Console.WriteLine("Cantidad de elementos en la colección: " + coleccionable.cuantos());
			Console.WriteLine("Mínimo elemento en la colección: " + coleccionable.minimo());
			Console.WriteLine("Máximo elemento en la colección: " + coleccionable.maximo());
		}
		
	}
}