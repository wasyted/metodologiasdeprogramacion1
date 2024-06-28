using System;

namespace MDPI
{
	public class FabricaDeAlumnos : FabricaDeComparables
	{
		GeneradorDeDatosAleatorios dato = new GeneradorDeDatosAleatorios();
		public override IComparable CrearAleatorio()
		{
			return new Alumno(dato.StringAleatorio(9), dato.NumeroAleatorio(99999999), dato.NumeroAleatorio(9999), dato.NumeroAleatorio(10));
		}
		
		public override IComparable CrearPorTeclado()
		{
			Console.WriteLine("\nIngrese nombre: ");
			string nombre = Console.ReadLine();
			Console.WriteLine("\nIngrese dni: ");
			int dni = int.Parse(Console.ReadLine());
			Console.WriteLine("\nIngrese legajo: ");
			int legajo = int.Parse(Console.ReadLine());
			Console.WriteLine("\nIngrese promedio: ");
			double promedio = double.Parse(Console.ReadLine());
			return new Alumno(nombre, dni, legajo, promedio);
		}
	}
}
