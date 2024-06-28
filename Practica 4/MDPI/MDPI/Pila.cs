using System;
using System.Collections.Generic;
	
namespace MDPI
{
		
	
	public class Pila : IColeccionable, Iterable
	{
		private List<IComparable> elementos;

		public Pila()
		{
			this.elementos = new List<IComparable>();
		}

		public int Cuantos()
		{
			return elementos.Count;
		}

		public IComparable Minimo()
		{
			if (elementos.Count == 0) {
				throw new InvalidOperationException("La pila está vacía.");
			}

			IComparable min = elementos[0];
			foreach (var elemento in elementos) {
				if (elemento.SosMenor(min)) {
					min = elemento;
				}
			}

			return min;
		}

		public IComparable Maximo()
		{
			if (elementos.Count == 0) {
				throw new InvalidOperationException("La pila está vacía.");
			}

			IComparable max = elementos[0];
			foreach (var elemento in elementos) {
				if (elemento.SosMayor(max)) {
					max = elemento;
				}
			}

			return max;
		}

		public void Agregar(IComparable comparable)
		{
			elementos.Add(comparable);
		}

		public bool Contiene(IComparable comparable)
		{
			for (int i = 0; i < elementos.Count; i++) {
				if (elementos[i].SosIgual(comparable)) {
					return true;
				}
			}
			return false;
		}
		
		public Iterador CrearIterador()
		{
			return new PilaIterador(this);
		}

		private class PilaIterador : Iterador
		{
			private Pila pila;
			private int posicion;

			public PilaIterador(Pila pila)
			{
				this.pila = pila;
				this.Primero();
			}

			public void Primero()
			{
				posicion = pila.elementos.Count - 1;
			}

			public void Siguiente()
			{
				posicion--;
			}

			public bool Fin()
			{
				return posicion < 0;
			}

			public object Actual()
			{
				if (Fin()) {
					return null;
				}
				return pila.elementos[posicion];
			}
		}
	}

}
