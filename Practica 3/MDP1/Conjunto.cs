using System;
using System.Collections;

namespace MDP1
{
	public class Conjunto : Coleccionable , Iterable
	{
		private ArrayList elementos;

		public Conjunto()
		{
			elementos = new ArrayList();
		}

		public void agregar(Comparable comparable)
		{
			if (!contiene(comparable)) {
				elementos.Add(comparable);
			}
		}

		public bool contiene(Comparable comparable)
		{
			foreach (Comparable elemento in elementos) {
				if (elemento.Equals(comparable)) {
					return true;
				}
			}
			return false;
		}

		public int cuantos()
		{
			return elementos.Count;
		}

		public Comparable minimo()
		{
			if (elementos.Count == 0) {
				throw new InvalidOperationException("El conjunto está vacío.");
			}

			Comparable min = (Comparable)elementos[0];
			foreach (Comparable elemento in elementos) {
				if (elemento.sosMenor(min)) {
					min = elemento;
				}
			}
			return min;
		}

		public Comparable maximo()
		{
			if (elementos.Count == 0) {
				throw new InvalidOperationException("El conjunto está vacío.");
			}

			Comparable max = (Comparable)elementos[0];
			foreach (Comparable elemento in elementos) {
				if (elemento.sosMayor(max)) {
					max = elemento;
				}
			}
			return max;
		}

		public Iterador crearIterador()
		{
			return new ConjuntoIterador(elementos);
		}
	}
}
