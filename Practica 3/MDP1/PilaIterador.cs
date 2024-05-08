using System.Collections;

namespace MDP1
{
	public class PilaIterador : Iterador
	{
		private ArrayList pila;
		private int indiceActual;

		public PilaIterador(ArrayList pila)
		{
			this.pila = pila;
			primero();
		}

		public void primero()
		{
			indiceActual = pila.Count - 1;
		}

		public void siguiente()
		{
			indiceActual--;
		}

		public bool fin()
		{
			return indiceActual < 0;
		}

		public Iterado actual()
		{
			if (fin()) {
				throw new System.InvalidOperationException("No hay elementos en la posición actual.");
			}
			return (Iterado)pila[indiceActual];
		}
	}
}
