using System;
using System.Collections;

namespace metodologia_de_programacion_I
{
    public class Pila : Coleccionable
    {
        ArrayList pila = new ArrayList();

        public Pila()
        {
        }

        public void apilar(Comparable c)
        {
            pila.Add(c);
        }

        public Comparable desapilar()
        {
            if (pila.Count == 0)
                return null;

            Comparable elemento = (Comparable)pila[pila.Count - 1];
            pila.RemoveAt(pila.Count - 1);
            return elemento;
        }

        public int cuantos()
        {
            return pila.Count;
        }

        public Comparable minimo()
        {
            if (pila.Count == 0)
                return null;

            Comparable min = (Comparable)pila[0];
            foreach (Comparable elemento in pila)
            {
                if (elemento.sosMenor(min))
                    min = elemento;
            }
            return min;
        }

        public Comparable maximo()
        {
            if (pila.Count == 0)
                return null;

            Comparable max = (Comparable)pila[0];
            foreach (Comparable elemento in pila)
            {
                if (elemento.sosMayor(max))
                    max = elemento;
            }
            return max;
        }

        public void agregar(Comparable c)
        {
            apilar(c);
        }

        public bool contiene(Comparable c)
        {
            foreach (Comparable elemento in pila)
            {
                if (elemento.sosIgual(c))
                    return true;
            }
            return false;
        }
    }
}
