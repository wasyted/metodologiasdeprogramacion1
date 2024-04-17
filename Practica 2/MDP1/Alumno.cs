using System;

namespace MDP1
{
	public class Alumno : Persona
	{
		private int legajo;
		private double promedio;
		private CompararEstrategia estrategiaComparacion;

		public Alumno(string n, int d, int l, double p, CompararEstrategia estrategia)
			: base(n, d)
		{
			this.legajo = l;
			this.promedio = p;
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
			return estrategia.sosIgual(c);
		}

		public override bool sosMenor(Comparable c)
		{
			return estrategia.sosMenor(c);
		}

		public override bool sosMayor(Comparable c)
		{
			return estrategia.sosMayor(c);
		}
		
		public override string ToString()
		{
			return string.Format("[Alumno Legajo={0}, Promedio={1}]", legajo, promedio);
		}

	}
}
