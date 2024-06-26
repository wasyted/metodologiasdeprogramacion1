using System;

namespace MDPI
{
	class Program
	{
		public static void Main(string[] args)
		{
			Pila pila = new Pila();
			llenarAlumnos(pila);

			Console.WriteLine("Con estrategia de comparación por Nombre:");
			CambiarEstrategia(pila, new CompararPorNombre());
			Informar(pila);

			Console.WriteLine("\nCon estrategia de comparación por Legajo:");
			CambiarEstrategia(pila, new CompararPorLegajo());
			Informar(pila);

			Console.WriteLine("\nCon estrategia de comparación por Promedio:");
			CambiarEstrategia(pila, new CompararPorPromedio());
			Informar(pila);

			Console.WriteLine("\nCon estrategia de comparación por DNI:");
			CambiarEstrategia(pila, new CompararPorDni());
			Informar(pila);
			
			Console.ReadKey();
		}

		public static void ImprimirElementos(Iterable coleccionable)
		{
			Iterador iterador = coleccionable.CrearIterador();
			for (iterador.Primero(); !iterador.Fin(); iterador.Siguiente()) {
				Console.WriteLine(iterador.Actual().ToString());
			}
		}
		
		public static void CambiarEstrategia(IColeccionable coleccionable, IEstrategiaComparacion estrategia)
		{
			Iterador iterador = ((Iterable)coleccionable).CrearIterador();
			for (iterador.Primero(); !iterador.Fin(); iterador.Siguiente()) {
				Alumno alumno = (Alumno)iterador.Actual();
				alumno.SetEstrategiaDeComparacion(estrategia);
			}
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
			IEstrategiaComparacion estrategia = new CompararPorDni();
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
				alumno.SetEstrategiaDeComparacion(estrategia);
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
		}
	}
}

