using System;
using System.Collections.Generic;

namespace MDPI
{

	public class Diccionario : IColeccionable, Iterable
	{
		private List<ClaveValor> elementos;

		public Diccionario()
		{
			elementos = new List<ClaveValor>();
		}

		public void Agregar(IComparable c){
			
		}
		
		public void Agregar(IComparable clave, object valor)
		{
			ClaveValor nuevoElemento = new ClaveValor(clave, valor);

			foreach (ClaveValor cv in elementos) {
				if (cv.Equals(nuevoElemento)) {
					cv.SetValor(valor);
					return;
				}
			}
			elementos.Add(nuevoElemento);
		}

		public object ValorDe(IComparable clave)
		{
			foreach (ClaveValor cv in elementos) {
				if (cv.Clave.Equals(clave)) {
					return cv.Valor;
				}
			}
			return null;
		}

		public int Cuantos()
		{
			return elementos.Count;
		}

		public IComparable Minimo()
		{
			if (elementos.Count == 0)
				return null;

			ClaveValor min = elementos[0];
			foreach (ClaveValor cv in elementos) {
				if (string.Compare(cv.Valor.ToString(), min.Valor.ToString(), StringComparison.Ordinal) < 0) {
					min = cv;
				}
			}
			return (IComparable)min.Valor;
		}

		public IComparable Maximo()
		{
			if (elementos.Count == 0)
				return null;

			ClaveValor max = elementos[0];
			foreach (ClaveValor cv in elementos) {
				if (string.Compare(cv.Valor.ToString(), max.Valor.ToString(), StringComparison.Ordinal) > 0) {
					max = cv;
				}
			}
			return (IComparable)max.Valor;
		}

		public bool Contiene(IComparable elemento)
		{
			foreach (ClaveValor cv in elementos) {
				if (cv.Valor.Equals(elemento)) {
					return true;
				}
			}
			return false;
		}
		
		public Iterador CrearIterador()
		{
			return new DiccionarioIterador(this);
		}
		
		private class DiccionarioIterador : Iterador
		{
			private Diccionario diccionario;
			private int posicion;

			public DiccionarioIterador(Diccionario diccionario)
			{
				this.diccionario = diccionario;
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
				return posicion >= diccionario.elementos.Count;
			}

			public object Actual()
			{
				if (Fin()) {
					return null;
				}
				return diccionario.elementos[posicion].Valor;
			}
		}
	}
}
