using System;
using System.Collections.Generic;

namespace MDPI
{
	public class Conjunto : IColeccionable, Iterable
	{
		private List<IComparable> elementos;
		private OrdenEnAula1 ordenInicio;
		private OrdenEnAula2 ordenLlegaAlumno;
		private OrdenEnAula1 ordenAulaLlena;
		private bool inicioInvocado = false;

		public Conjunto()
		{
			elementos = new List<IComparable>();
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

		public void Agregar(IComparable elemento)
		{
			if (!inicioInvocado) {
				ordenInicio.ejecutar();
				inicioInvocado = true;
			}
        
			ordenLlegaAlumno.ejecutar(elemento);
			if (!Pertenece(elemento)) {
				elementos.Add(elemento);
			}

			if (elementos.Count == 40) {
				ordenAulaLlena.ejecutar();
			}
		}

		public bool Pertenece(IComparable elemento)
		{
			foreach (IComparable e in elementos) {
				if (e.Equals(elemento)) {
					return true;
				}
			}
			return false;
		}

		public int Cuantos()
		{
			return elementos.Count;
		}

		public IComparable Minimo()
		{
			if (elementos.Count == 0) {
				throw new InvalidOperationException("La colección está vacía.");
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
				throw new InvalidOperationException("La colección está vacía.");
			}

			IComparable max = elementos[0];
			foreach (var elemento in elementos) {
				if (elemento.SosMayor(max)) {
					max = elemento;
				}
			}

			return max;
		}

		public bool Contiene(IComparable elemento)
		{
			return Pertenece(elemento);
		}
		
		public Iterador CrearIterador()
		{
			return new ConjuntoIterador(this);
		}

		private class ConjuntoIterador : Iterador
		{
			private Conjunto conjunto;
			private int posicion;

			public ConjuntoIterador(Conjunto conjunto)
			{
				this.conjunto = conjunto;
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
				return posicion >= conjunto.elementos.Count;
			}

			public object Actual()
			{
				if (Fin()) {
					return null;
				}
				return conjunto.elementos[posicion];
			}
		}
	}
	
}
