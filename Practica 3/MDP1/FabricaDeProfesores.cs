using System;

namespace MDP1
{
	public class FabricaDeProfesores : FabricaDeComparables
	{
		public Comparable crearAleatorio(int opcion)
		{
			// Para simplificar, generamos un profesor aleatorio con valores ficticios
			Random rnd = new Random();
			string nombre = "Profesor" + rnd.Next(1, 100);
			int dni = rnd.Next(10000000, 99999999);
			int antiguedad = rnd.Next(1, 31); // Suponemos que la antigüedad va de 1 a 30 años
			return new Profesor(nombre, dni, antiguedad);
		}

		public Comparable crearPorTeclado(int opcion)
		{
			// Aquí podrías solicitar al usuario que ingrese los datos del profesor por teclado
			throw new NotImplementedException();
		}
	}


}
