using System;

namespace MDP1
{
	public class FabricaDeNumeros : FabricaDeComparables
	{
		private GeneradorDeDatosAleatorios generadorAleatorio;

		public FabricaDeNumeros()
		{
			generadorAleatorio = new GeneradorDeDatosAleatorios();
		}

		public Comparable crearAleatorio(int opcion)
		{
			int numero = generadorAleatorio.numeroAleatorio(100);
			return new Numero(numero);
		}

		public Comparable crearPorTeclado(int opcion)
		{
			throw new NotImplementedException("No se ha implementado la creación por teclado para números.");
		}
	}
}
