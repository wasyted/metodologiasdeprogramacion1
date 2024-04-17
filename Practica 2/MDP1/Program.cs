using System;

namespace MDP1
{
	class Program
	{
		
		public static void Main(string[] args)
		{
			
			//Ejercicio 7
			
			/* 
			Pila pila = new Pila();
			Cola cola = new Cola();

			llenar(pila);
			llenar(cola);
			
			Console.WriteLine("******************************************************");
			Console.WriteLine("Información de la Pila:");
			informar(pila);

			Console.WriteLine("******************************************************");
			Console.WriteLine("\nInformación de la Cola:");
			informar(cola);
			*/
			
			//Ejercicio 9
			
			/*
			Pila pila = new Pila();
			Cola cola = new Cola();
			ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);

			llenar(pila);
			llenar(cola);

			Console.WriteLine("******************************************************");
			Console.WriteLine("Información de la Pila:");
			informar(pila);

			Console.WriteLine("******************************************************");
			Console.WriteLine("\nInformación de la Cola:");
			informar(cola);
			
			Console.WriteLine("******************************************************");
			Console.WriteLine("\nInformación de la Colección Múltiple:");
			informar(multiple);
			*/
			
			//Ejercicio 13
			
			/*
			Pila pila = new Pila();
			Cola cola = new Cola();
			ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);

			llenarPersonas(pila);
			llenarPersonas(cola);

			Console.WriteLine("Información de la Colección Múltiple:");
			informar(multiple);
			*/
			
			//Ejercicio 17
			
			Pila pila = new Pila();
			Cola cola = new Cola();
			
			llenarAlumnos(cola);
			llenarAlumnos(pila);
			
			ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
		
			Console.WriteLine("Información de la Colección Múltiple:");
			informar(multiple);
					
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void llenar(Coleccionable coleccionable)
		{
			
			Random rnd = new Random();
			
			for (int i = 0; i < 20; i++) {
				
				int valor = rnd.Next(1, 100); // Genera un valor aleatorio entre 1 y 100
				Numero numero = new Numero(valor);
				coleccionable.agregar(numero);
			}
		}
		
		/*
		public static void informar(Coleccionable coleccionable)
		{
			
			Console.WriteLine("∗ Cantidad de elementos en la colección: " + coleccionable.cuantos());
			Numero minimo = (Numero)coleccionable.minimo();
			Numero maximo = (Numero)coleccionable.maximo();
			Console.WriteLine("∗ Elemento mínimo: " + minimo.getValor());
			Console.WriteLine("∗ Elemento máximo: " + maximo.getValor());
			Console.Write("\nIngrese un valor para verificar si está en la colección: ");
			
			int valor = int.Parse(Console.ReadLine());
			Comparable comparable = new Numero(valor);

			if (coleccionable.contiene(comparable)) {
				Console.WriteLine("\nEl elemento leído está en la colección");
				Console.WriteLine("");
			} else {
				Console.WriteLine("\nEl elemento leído no está en la colección");
				Console.WriteLine("");
			}
		}
		*/
		
		//Ejercicio 13
		
		/*
		public static void informar(Coleccionable coleccionable)
		{
			
			Persona dniPersonaMinimo = (Persona)coleccionable.minimo();
			Persona dniPersonaMaximo = (Persona)coleccionable.maximo();
			
			Console.WriteLine("∗ Cantidad de elementos en la colección: " + coleccionable.cuantos());
			Console.WriteLine("∗ Elemento mínimo: " + dniPersonaMinimo.getDNI());
			Console.WriteLine("∗ Elemento máximo: " + dniPersonaMaximo.getDNI());
			Console.Write("\nIngrese un valor para verificar si está en la colección: ");
			
			int valor = int.Parse(Console.ReadLine());
			Comparable comparable = new Numero(valor);

			if (coleccionable.contiene(comparable)) {
				Console.WriteLine("\nEl elemento leído está en la colección");
				Console.WriteLine("");
			} else {
				Console.WriteLine("\nEl elemento leído no está en la colección");
				Console.WriteLine("");
			}
		}
		*/
		
		public static void informar(Coleccionable coleccionable)
		{
			
			Console.WriteLine("∗ Cantidad de elementos en la colección: " + coleccionable.cuantos());
			Console.WriteLine("∗ Elemento mínimo: " + coleccionable.minimo());
			Console.WriteLine("∗ Elemento máximo: " + coleccionable.maximo());
			Console.Write("\nIngrese un valor para verificar si está en la colección: ");
			
			int valor = int.Parse(Console.ReadLine());
			Comparable comparable = new Numero(valor);

			if (coleccionable.contiene(comparable)) {
				Console.WriteLine("\nEl elemento leído está en la colección");
				Console.WriteLine("");
			} else {
				Console.WriteLine("\nEl elemento leído no está en la colección");
				Console.WriteLine("");
			}
		}
		
		public static void llenarPersonas(Coleccionable coleccionable)
		{
			Random rnd = new Random();

			for (int i = 0; i < 20; i++) {
				string nombre = "Persona" + rnd.Next(1, 100);
				int dni = rnd.Next(10000000, 99999999);

				Persona persona = new Persona(nombre, dni);
				coleccionable.agregar(persona);
			}
		}
		
		public static void llenarAlumnos(Coleccionable coleccionable)
		{
			Random rnd = new Random();

			for (int i = 0; i < 20; i++) {
				string nombre = "Alumno" + rnd.Next(1, 100);
				int dni = rnd.Next(10000000, 99999999);
				int legajo = rnd.Next(1000, 2000);
				double promedio = rnd.NextDouble() * 10;

				Alumno alumno = new Alumno(nombre, dni, legajo, promedio);
				coleccionable.agregar(alumno);
			}
		}

	}
}