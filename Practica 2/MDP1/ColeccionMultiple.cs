using System;

namespace MDP1
{
	public class ColeccionMultiple : Coleccionable
	{
		private Pila pila;
		private Cola cola;
	
		public ColeccionMultiple(Pila p, Cola c)
		{
			this.pila = p;
			this.cola = c;
		}
	
		public int cuantos()
		{
			return pila.cuantos() + cola.cuantos();
		}
	
		public Comparable minimo()
		{
			Comparable minPila = pila.minimo();
			Comparable minCola = cola.minimo();

			return minPila.sosMenor(minCola) ? minPila : minCola;
		}
	
		public Comparable maximo()
		{
			Comparable maxPila = pila.maximo();
			Comparable maxCola = cola.maximo();
	
			return maxPila.sosMayor(maxCola) ? maxPila : maxCola;
		}
	
		public void agregar(Comparable c)
		{
			// No hace nada
		}
	
		public bool contiene(Comparable c)
		{
			return pila.contiene(c) || cola.contiene(c);
		}
	}

}
