using System;

namespace MDP1
{
	public class CompararLegajo : CompararEstrategia
	{
		public bool sosIgual(Alumno c , Alumno c2)
		{
			return c.getLegajo() == c2.getLegajo();
		}

		public bool sosMenor(Alumno c , Alumno c2)
		{
			return c2.getLegajo() < c.getLegajo();
		}

		public bool sosMayor(Alumno c , Alumno c2)
		{
			return c2.getLegajo() > c.getLegajo();
		}
	}
}

