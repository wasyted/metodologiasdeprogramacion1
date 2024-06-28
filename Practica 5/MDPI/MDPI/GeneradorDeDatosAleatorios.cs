using System;
using System.Text;

namespace MDPI
{
	public class GeneradorDeDatosAleatorios
	{
		private static Random random = new Random();

		// Método que devuelve un número aleatorio entre 0 y max
		public int NumeroAleatorio(int max)
		{
			return random.Next(0, max + 1);
		}

		// Método que devuelve un string aleatorio de 'cant' caracteres
		public string StringAleatorio(int cant)
		{
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			StringBuilder result = new StringBuilder(cant);
			for (int i = 0; i < cant; i++) {
				result.Append(chars[random.Next(chars.Length)]);
			}
			return result.ToString();
		}
	}
}