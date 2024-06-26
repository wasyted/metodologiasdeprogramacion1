using System;
using System.Collections.Generic;

namespace MDPI
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//Practica 3 Ejercicio 13 
			
			Profesor profesor = new Profesor("Juan Pérez", 12345678, 10);
			Pila alumnos = new Pila();
			
			Llenar(alumnos, 2);
			
			Observar(alumnos, profesor);

			dictadoDeClases(profesor);

			Console.ReadKey();
		}

		public static void dictadoDeClases(Profesor profesor)
		{
			for (int i = 0; i < 5; i++) {
				profesor.HablarALaClase();
				profesor.EscribirEnElPizarron();
			}
		}
		
		public static void Llenar(IColeccionable coleccionable, int opcion)
		{
			for (int i = 0; i < 20; i++) {
				IComparable comparable = FabricaDeComparables.CrearAleatorio(opcion);
				coleccionable.Agregar(comparable);
			}
		}
		
		public static void Observar(IColeccionable coleccionable, Profesor profesor)
		{
			Iterador iterador = ((Iterable)coleccionable).CrearIterador();
			for (iterador.Primero(); !iterador.Fin(); iterador.Siguiente()) {
				Alumno alumno = (Alumno)iterador.Actual();
				profesor.agregarObservador(alumno);
			}
		}
		
		/*
			 * Practica 3 Ejercicio 1-13
			 * 
			// Creación de las estructuras de datos
			Pila pila = new Pila();
			Cola cola = new Cola();
			Conjunto conjunto = new Conjunto();
			Diccionario diccionario = new Diccionario();

			// Opción para seleccionar el tipo de comparable
			int opcion = 3; // 1 para Numero, 2 para Alumno (según lo definido en la fábrica)

			// Llenar y informar la Pila
			Console.WriteLine("=== Información de la Pila ===");
			Llenar(pila, opcion);

			// Llenar y informar la Cola
			Console.WriteLine("=== Información de la Cola ===");
			Llenar(cola, opcion);

			// Llenar y informar el Conjunto
			Console.WriteLine("=== Información del Conjunto ===");
			Llenar(conjunto, opcion);

			// Llenar y informar el Diccionario
			Console.WriteLine("=== Información del Diccionario ===");
			Llenar(diccionario, opcion);

			Console.WriteLine("Programa finalizado correctamente.");
			Console.ReadKey(true);
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

		public static void Llenar(IColeccionable coleccionable, int opcion)
		{

			for (int i = 0; i < 20; i++) {
				IComparable comparable = FabricaDeComparables.CrearAleatorio(opcion);
				Console.WriteLine(comparable);
				coleccionable.Agregar(comparable);
			}

			informar(coleccionable, opcion);
		}

		public static void informar(IColeccionable coleccionable, int opcion)
		{
			
			ImprimirElementos((Iterable)coleccionable);
			
			Console.WriteLine("Cantidad de elementos: " + coleccionable.Cuantos());

			IComparable minimo = coleccionable.Minimo();
			IComparable maximo = coleccionable.Maximo();

			if (minimo != null) {
				Console.WriteLine("Mínimo elemento: " + minimo);
			} else {
				Console.WriteLine("No hay elementos mínimos.");
			}

			if (maximo != null) {
				Console.WriteLine("Máximo elemento: " + maximo);
			} else {
				Console.WriteLine("No hay elementos máximos.");
			}
			
			IComparable comparable = FabricaDeComparables.CrearPorTeclado(opcion);
			
			if(coleccionable.Contiene(comparable)){
			   	Console.WriteLine("Está.");
			} else {
				Console.WriteLine("No está.");
			}
		}
		*/
	}
}

