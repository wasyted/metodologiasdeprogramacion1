using System;

namespace MDPI
{
	class Program
	{
		static void Main()
		{
			// Crear una Pila y una Cola
			Pila pila = new Pila();
			Cola cola = new Cola();

			// Crear una ColeccionMultiple
			ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);

			// Llenar la Pila y la Cola con Alumnos
			llenarAlumnos(pila);
			llenarAlumnos(cola);

			// Informar sobre la ColeccionMultiple
			Console.WriteLine("\nInformación de la colección múltiple con Alumnos:");
			Informar(multiple);
			
			Console.ReadKey();
		}

		static void llenarPersonas(IColeccionable coleccionable)
		{
			Random random = new Random();
			string[] nombres = {
				"Juan", "Maria", "Pedro", "Ana", "Luis", "Lucia", "Carlos", "Marta", "Jorge", "Sofia",
				"Miguel", "Carmen", "Jose", "Laura", "David", "Elena", "Rafael", "Isabel", "Mario", "Paula"
			};

			for (int i = 0; i < 20; i++) {
				string nombre = nombres[random.Next(nombres.Length)];
				int dni = random.Next(10000000, 99999999); // Genera un número de DNI aleatorio
				Persona persona = new Persona(nombre, dni);
				coleccionable.Agregar(persona);
			}
		}

		static void llenarAlumnos(IColeccionable coleccionable)
		{
			Random random = new Random();
			string[] nombres = {
				"Juan", "Maria", "Pedro", "Ana", "Luis", "Lucia", "Carlos", "Marta", "Jorge", "Sofia",
				"Miguel", "Carmen", "Jose", "Laura", "David", "Elena", "Rafael", "Isabel", "Mario", "Paula"
			};

			for (int i = 0; i < 20; i++) {
				string nombre = nombres[random.Next(nombres.Length)];
				int dni = random.Next(10000000, 99999999); // Genera un número de DNI aleatorio
				int legajo = random.Next(1000, 9999); // Genera un número de legajo aleatorio
				double promedio = random.NextDouble() * (10.0 - 5.0) + 5.0; // Genera un promedio aleatorio entre 5.0 y 10.0
				Alumno alumno = new Alumno(nombre, dni, legajo, promedio);
				coleccionable.Agregar(alumno);
			}
		}

		static void Informar(IColeccionable coleccionable)
		{
			Console.WriteLine("Cantidad de elementos: " + coleccionable.Cuantos());
			IComparable min = coleccionable.Minimo();
			Alumno minAlumno = (Alumno)min;
			Console.WriteLine("Alumno mínimo: Nombre: " + minAlumno.GetNombre() + ", DNI: " + minAlumno.GetDNI() + ", Legajo: " + minAlumno.GetLegajo() + ", Promedio: " + minAlumno.GetPromedio());

			IComparable max = coleccionable.Maximo();
			Alumno maxAlumno = (Alumno)max;
			Console.WriteLine("Alumno máximo: Nombre: " + maxAlumno.GetNombre() + ", DNI: " + maxAlumno.GetDNI() + ", Legajo: " + maxAlumno.GetLegajo() + ", Promedio: " + maxAlumno.GetPromedio());

			Console.Write("Ingrese un número de DNI para verificar si está en la colección: ");
			string input = Console.ReadLine();
			int dniLeido;

			if (int.TryParse(input, out dniLeido)) {
				Persona comparable = new Persona("Nombre", dniLeido);
				if (coleccionable.Contiene(comparable)) {
					Console.WriteLine("El elemento leído está en la colección.");
				} else {
					Console.WriteLine("El elemento leído no está en la colección.");
				}
			} else {
				Console.WriteLine("Entrada inválida. Debe ingresar un número entero.");
			}
		}
	}
}

