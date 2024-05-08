using System;
using System.Collections;

namespace MDP1
{
	public class Diccionario<TKey, TValue> : Conjunto , Iterable
	{
		private ArrayList elementos;

		public Diccionario()
		{
			elementos = new ArrayList();
		}

		public void agregar(TKey c, TValue v)
		{
			ClaveValor<TKey, TValue> nuevoClaveValor = new ClaveValor<TKey, TValue>(c, v);
			int indice = elementos.IndexOf(nuevoClaveValor);
			if (indice != -1) {
				elementos[indice] = nuevoClaveValor;
			} else {
				elementos.Add(nuevoClaveValor);
			}
		}

		public TValue valorDe(TKey c)
		{
			foreach (ClaveValor<TKey, TValue> cv in elementos) {
				if (cv.clave.Equals(c)) {
					return cv.valor;
				}
			}
			return default(TValue);
		}
	}
}
