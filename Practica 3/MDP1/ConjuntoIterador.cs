using System.Collections;

namespace MDP1
{
	public class ConjuntoIterador : Iterador
	{
		private ArrayList conjunto;
		private int indiceActual;

		public ConjuntoIterador(ArrayList conjunto)
		{
			this.conjunto = conjunto;
			primero();
		}

		public void primero()
		{
			indiceActual = 0;
		}

		public void siguiente()
		{
			indiceActual++;
		}

		public bool fin()
		{
			return indiceActual >= conjunto.Count;
		}

		public Iterado actual()
		{
			if (fin()) {
				throw new System.InvalidOperationException("No hay elementos en la posición actual.");
			}
			return (Iterado)conjunto[indiceActual];
		}
	}
}

