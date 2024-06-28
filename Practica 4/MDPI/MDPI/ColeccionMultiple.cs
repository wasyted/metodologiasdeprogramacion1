using System;

namespace MDPI
{
	public class ColeccionMultiple : IColeccionable
	{
		private Pila pila;
		private Cola cola;

		public ColeccionMultiple(Pila p, Cola c)
		{
			pila = p;
			cola = c;
		}

		public int Cuantos()
		{
			return pila.Cuantos() + cola.Cuantos();
		}

		public IComparable Minimo()
		{
			IComparable minimoPila = pila.Minimo();
			IComparable minimoCola = cola.Minimo();
			return minimoPila.SosMenor(minimoCola) ? minimoPila : minimoCola;
		}

		public IComparable Maximo()
		{
			IComparable maximoPila = pila.Maximo();
			IComparable maximoCola = cola.Maximo();
			return maximoPila.SosMayor(maximoCola) ? maximoPila : maximoCola;
		}

		public void Agregar(IComparable comparable)
		{
			// No hace nada
		}

		public bool Contiene(IComparable comparable)
		{
			return pila.Contiene(comparable) || cola.Contiene(comparable);
		}
	}
}
