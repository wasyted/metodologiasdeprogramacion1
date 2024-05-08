using System;

namespace MDP1
{
	public class FabricaDeAlumnos : FabricaDeComparables
	{
		private GeneradorDeDatosAleatorios generadorAleatorio;
		private LectorDeDatos lectorDeDatos;

		public FabricaDeAlumnos()
		{
			generadorAleatorio = new GeneradorDeDatosAleatorios();
			lectorDeDatos = new LectorDeDatos();
		}

		public Comparable crearAleatorio(int opcion)
		{
			string nombre = generadorAleatorio.stringAleatorio(8);
			int dni = generadorAleatorio.numeroAleatorio(99999999);
			return new Alumno(nombre, dni, 0, 0);
		}

		public Comparable crearPorTeclado(int opcion)
		{
			if (opcion == 1) {
				int dni = generadorAleatorio.numeroAleatorio(99999999);
				string nombre = lectorDeDatos.stringPorTeclado();
				return new Alumno(nombre, dni, 0, 0);
			} else if (opcion == 2) {
				string nombre = lectorDeDatos.stringPorTeclado();
				int dni = lectorDeDatos.numeroPorTeclado();
				return new Alumno(nombre, dni, 0, 0);
			} else {
				throw new ArgumentException("Opción inválida para crear alumno por teclado.");
			}
		}
	}
}
