using System;

namespace MDP1
{
	public class Numero : Comparable
	{
		private int valor;
	
		public Numero(int v)
		{
			this.valor = v;
		}
	
		public int getValor()
		{
			return this.valor;
		}
	
		// Implementación de la interfaz Comparable
		public bool sosIgual(Comparable otro)
		{
			if (otro == null || !(otro is Numero)) {
				return false;
			}
	
			Numero otroNumero = (Numero)otro;
			return this.valor == otroNumero.getValor();
		}
	
		public bool sosMenor(Comparable otro)
		{
			if (otro == null || !(otro is Numero)) {
				return false;
			}
	
			Numero otroNumero = (Numero)otro;
			return this.valor < otroNumero.getValor();
		}
	
		public bool sosMayor(Comparable otro)
		{
			if (otro == null || !(otro is Numero)) {
				return false;
			}
	
			Numero otroNumero = (Numero)otro;
			return this.valor > otroNumero.getValor();
		}
	}
}
