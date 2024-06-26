	using System;
	using System.Collections.Generic;
	
	namespace MDPI{
		
	
	public class Pila : IColeccionable
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
	}

}
