using System;

namespace MDPI
{
	public class Numero : IComparable
	{
		private int valor;

		public Numero(int v)
		{
			this.valor = v;
		}

		public int GetValor()
		{
			return valor;
		}

		// Implementación del método SosIgual de la interfaz IComparable
		public bool SosIgual(IComparable otro)
		{
			Numero otroNumero = (Numero)otro;
			return this.GetValor() == otroNumero.GetValor();
		}

		// Implementación del método SosMenor de la interfaz IComparable
		public bool SosMenor(IComparable otro)
		{
			Numero otroNumero = (Numero)otro;
			return this.valor < otroNumero.GetValor();
		}

		// Implementación del método SosMayor de la interfaz IComparable
		public bool SosMayor(IComparable otro)
		{
			Numero otroNumero = (Numero)otro;
			return this.valor > otroNumero.GetValor();
		}
		
		public override string ToString()
		{
			return string.Format("[Numero {0}]", this.GetValor());
		}
	}
}
