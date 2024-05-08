using System;

namespace MDP1
{
	public class LectorDeDatos
	{
		public int numeroPorTeclado()
		{
			int numero;
			while (true) {
				Console.WriteLine("Ingrese un número:");
				if (int.TryParse(Console.ReadLine(), out numero)) {
					return numero;
				} else {
					Console.WriteLine("Error: Ingrese un número válido.");
				}
			}
		}

		public string stringPorTeclado()
		{
			Console.WriteLine("Ingrese un string:");
			return Console.ReadLine();
		}
	}
}
