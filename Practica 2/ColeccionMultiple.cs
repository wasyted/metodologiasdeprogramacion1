using System;

namespace metodologia_de_programacion_I
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
            Comparable minimoPila = pila.minimo();
            Comparable minimoCola = cola.minimo();

            if (minimoPila == null)
                return minimoCola;
            if (minimoCola == null)
                return minimoPila;

            return minimoPila.sosMenor(minimoCola) ? minimoPila : minimoCola;
        }

        public Comparable maximo()
        {
            Comparable maximoPila = pila.maximo();
            Comparable maximoCola = cola.maximo();

            if (maximoPila == null)
                return maximoCola;
            if (maximoCola == null)
                return maximoPila;

            return maximoPila.sosMayor(maximoCola) ? maximoPila : maximoCola;
        }

        public void agregar(Comparable c)
        {
            // No hace nada, ya que no se puede agregar directamente a la colección múltiple
        }

        public bool contiene(Comparable c)
        {
            return pila.contiene(c) || cola.contiene(c);
        }
    }
}

