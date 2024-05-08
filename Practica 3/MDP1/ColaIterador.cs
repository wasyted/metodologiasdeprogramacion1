using System.Collections;

namespace MDP1
{
	public class ColaIterador : Iterador
	{
		private ArrayList cola;
		private int indiceActual;

		public ColaIterador(ArrayList cola)
		{
			this.cola = cola;
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
			return indiceActual >= cola.Count;
		}

		public Iterado actual()
		{
			if (fin()) {
				throw new System.InvalidOperationException("No hay elementos en la posición actual.");
			}
			return (Iterado)cola[indiceActual];
		}
	}
}

