using System;

namespace MDPI
{
	public abstract class FabricaDeComparables
	{
		public static IComparable CrearAleatorio(int opcion)
		{
			FabricaDeComparables fabrica = null;
			switch (opcion) {
				case 1: fabrica = new FabricaDeNumeros(); break;
				case 2: fabrica = new FabricaDeAlumnos(); break;
				case 3: fabrica = new FabricaDeProfesores(); break;
				case 4: fabrica = new FabricaDeAlumnosMuyEstudiosos(); break;
			}
			return fabrica.CrearAleatorio();
		}
		
		public static IComparable CrearPorTeclado(int opcion)
		{
			FabricaDeComparables fabrica = null;
			switch (opcion) {
				case 1: fabrica = new FabricaDeNumeros(); break;
				case 2: fabrica = new FabricaDeAlumnos(); break;
				case 3: fabrica = new FabricaDeProfesores(); break;
				case 4: fabrica = new FabricaDeAlumnosMuyEstudiosos(); break;
			}
			return fabrica.CrearPorTeclado();
		}
		
		abstract public IComparable CrearAleatorio();
		abstract public IComparable CrearPorTeclado();
	}
}
