using System;
using System.Collections;

namespace MDP1
{
	public class Cola : Coleccionable, Iterable
	{
		ArrayList cola = new ArrayList();

		public void encolar(Comparable c)
		{
			cola.Add(c);
		}

		public Comparable desencolar()
		{
			Comparable elemento = (Comparable)cola[0];
			cola.RemoveAt(0);
			return elemento;
		}

		public int cuantos()
		{
			return cola.Count;
		}

		public Comparable minimo()
		{
			if (cola.Count == 0)
				return null;

			Comparable min = (Comparable)cola[0];
			foreach (Comparable elemento in cola) {
				if (elemento.sosMenor(min))
					min = elemento;
			}
			return min;
		}

		public Comparable maximo()
		{
			if (cola.Count == 0)
				return null;

			Comparable max = (Comparable)cola[0];
			foreach (Comparable elemento in cola) {
				if (elemento.sosMayor(max))
					max = elemento;
			}
			return max;
		}

		public void agregar(Comparable c)
		{
			encolar(c);
		}

		public bool contiene(Comparable c)
		{
			foreach (Comparable elemento in cola) {
				if (elemento.sosIgual(c))
					return true;
			}
			return false;
		}
		
		public Iterador crearIterador()
		{
			return new ColaIterador(cola);
		}
	}
}
