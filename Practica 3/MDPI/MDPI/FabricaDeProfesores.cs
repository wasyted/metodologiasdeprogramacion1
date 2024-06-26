using System;

namespace MDPI
{
	public class FabricaDeProfesores : FabricaDeComparables
	{
		GeneradorDeDatosAleatorios dato = new GeneradorDeDatosAleatorios();
		public override IComparable CrearAleatorio()
		{
			return new Profesor(dato.StringAleatorio(9), dato.NumeroAleatorio(99999999), dato.NumeroAleatorio(35));
		}
		
		public override IComparable CrearPorTeclado()
		{
			Console.WriteLine("\nIngrese nombre: ");
			string nombre = Console.ReadLine();
			Console.WriteLine("\nIngrese dni: ");
			int dni = int.Parse(Console.ReadLine());
			Console.WriteLine("\nIngrese legajo: ");
			int antiguedad = int.Parse(Console.ReadLine());
			return new Profesor(nombre, dni, antiguedad);
		}
	}
}