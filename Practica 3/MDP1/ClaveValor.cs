/*
 * Creado por SharpDevelop.
 * Usuario: laboratorio
 * Fecha: 18/04/2024
 * Hora: 09:03 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace MDP1
{
    public class ClaveValor<TKey, TValue>
    {
        public TKey clave { get; private set; }
        public TValue valor { get; private set; }

        public ClaveValor(TKey c, TValue v)
        {
            this.clave = c;
            this.valor = v;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is ClaveValor<TKey, TValue>))
                return false;

            ClaveValor<TKey, TValue> otro = (ClaveValor<TKey, TValue>)obj;
            return this.clave.Equals(otro.clave);
        }

        public override int GetHashCode()
        {
            return clave.GetHashCode();
        }
    }
}
