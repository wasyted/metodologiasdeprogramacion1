using System.Collections.Generic;

namespace MDP1
{
	public class DiccionarioIterador : Iterador
	{
		private Dictionary<int, Comparable> elementos;
		private int indiceActual;

		public DiccionarioIterador(Dictionary<int, Comparable> elementos)
		{
			this.elementos = elementos;
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
			return indiceActual >= elementos.Count;
		}

		public Iterado actual()
		{
			if (fin()) {
				throw new System.InvalidOperationException("No hay elementos en la posición actual.");
			}
			return (Iterado)elementos[indiceActual];
		}
		public Iterador crearIterador()
		{
			return new DiccionarioIterador(elementos);
		}
	}
}

