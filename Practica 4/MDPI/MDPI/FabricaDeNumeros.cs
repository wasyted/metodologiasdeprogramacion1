using System;

namespace MDPI
{
	public class FabricaDeNumeros : FabricaDeComparables
	{
		public override IComparable CrearAleatorio()
		{
			return new Numero(new GeneradorDeDatosAleatorios().NumeroAleatorio(100));
		}
		
		public override IComparable CrearPorTeclado(){
			return new Numero(int.Parse(Console.ReadLine()));
		}
	}
}
