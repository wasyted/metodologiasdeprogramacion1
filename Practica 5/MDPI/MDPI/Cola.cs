using System;
using System.Collections.Generic;

namespace MDPI
{
	public class Cola : IColeccionable, Iterable
	{
		private List<IComparable> elementos;
		private OrdenEnAula1 ordenInicio;
		private OrdenEnAula2 ordenLlegaAlumno;
		private OrdenEnAula1 ordenAulaLlena;
		private bool inicioInvocado = false;

		public Cola()
		{
			this.elementos = new List<IComparable>();
		}

		public int Cuantos()
		{
			return elementos.Count;
		}
		
		public void setOrdenInicio(OrdenEnAula1 orden)
		{
			this.ordenInicio = orden;
		}

		public void setOrdenLlegaAlumno(OrdenEnAula2 orden)
		{
			this.ordenLlegaAlumno = orden;
		}

		public void setOrdenAulaLlena(OrdenEnAula1 orden)
		{
			this.ordenAulaLlena = orden;
		}

		public IComparable Minimo()
		{
			if (elementos.Count == 0) {
				throw new InvalidOperationException("La cola está vacía.");
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
				throw new InvalidOperationException("La cola está vacía.");
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
			
			if (!inicioInvocado) {
				ordenInicio.ejecutar();
				inicioInvocado = true;
			}
			elementos.Add(comparable);  
			ordenLlegaAlumno.ejecutar(comparable);

			if (elementos.Count == 40) {
				ordenAulaLlena.ejecutar();
			}
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
			return new ColaIterador(this);
		}

		private class ColaIterador : Iterador
		{
			private Cola cola;
			private int posicion;

			public ColaIterador(Cola cola)
			{
				this.cola = cola;
				this.Primero();
			}

			public void Primero()
			{
				posicion = 0;
			}

			public void Siguiente()
			{
				posicion++;
			}

			public bool Fin()
			{
				return posicion >= cola.elementos.Count;
			}

			public object Actual()
			{
				if (Fin()) {
					return null;
				}
				return cola.elementos[posicion];
			}
		}
	}
}
