using System;

namespace MDPI
{
	public class LectorDeDatos
	{
		
		public double NumeroPorTeclado()
		{
			double numero = double.Parse(Console.ReadLine());
			return numero;
		}
		
		public string StringPorTeclado()
		{
			string texto = Console.ReadLine();
			return texto;
		}
	}
}
