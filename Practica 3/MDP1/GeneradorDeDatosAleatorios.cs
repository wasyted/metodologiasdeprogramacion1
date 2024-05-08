using System;

namespace MDP1
{
	public class GeneradorDeDatosAleatorios
	{
		private Random random;

		public GeneradorDeDatosAleatorios()
		{
			random = new Random();
		}

		public int numeroAleatorio(int max)
		{
			return random.Next(max + 1);
		}

		public string stringAleatorio(int cant)
		{
			const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			char[] resultado = new char[cant];

			for (int i = 0; i < cant; i++) {
				resultado[i] = caracteres[random.Next(caracteres.Length)];
			}

			return new string(resultado);
		}
	}
}