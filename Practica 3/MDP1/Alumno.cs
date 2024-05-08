using System;

namespace MDP1
{
	public class Alumno : Persona , Iterado
	{
		private int legajo;
		private double promedio;
		private CompararEstrategia estrategiaComparacion;

		public Alumno(string n, int d, int l, double p)
			: base(n, d)
		{
			this.legajo = l;
			this.promedio = p;
			this.estrategiaComparacion = new CompararNombre();
		}

		public void setEstrategiaComparacion(CompararEstrategia estrategia)
		{
			this.estrategiaComparacion = estrategia;
		}
		
		public int getLegajo()
		{
			return legajo;
		}

		public double getPromedio()
		{
			return promedio;
		}

		public override bool sosIgual(Comparable c)
		{
			return estrategiaComparacion.sosIgual((Alumno)c, this);
		}

		public override bool sosMenor(Comparable c)
		{
			return estrategiaComparacion.sosMenor((Alumno)c, this);
		}

		public override bool sosMayor(Comparable c)
		{
			return estrategiaComparacion.sosMayor((Alumno)c, this);
		}
		
		public override string ToString()
		{
			return string.Format("[Alumno Nombre={3}, Legajo={0}, Promedio={1}, Dni={2}]", legajo, promedio, getDNI(), getNombre());
		}

	}
}
