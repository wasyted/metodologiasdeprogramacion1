using System;
using System.Collections.Generic;
	
namespace MDPI
{
		
	
	public class Pila : IColeccionable, Iterable, Ordenable
	{
		private List<IComparable> elementos;
		private OrdenEnAula1 ordenInicio;
		private OrdenEnAula2 ordenLlegaAlumno;
		private OrdenEnAula1 ordenAulaLlena;
		private bool inicioInvocado = false;

		public Pila()
		{
			this.elementos = new List<IComparable>();
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
			if (!inicioInvocado) {
				ordenInicio.ejecutar();
				inicioInvocado = true;
			}
        
			ordenLlegaAlumno.ejecutar(comparable);
			elementos.Add(comparable);

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
