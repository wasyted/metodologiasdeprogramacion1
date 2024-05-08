using System;

namespace MDP1
{
	public class CompararNombre : CompararEstrategia
	{
		public bool sosIgual(Alumno c, Alumno c2)
		{
			return c.getNombre().Equals(c2.getNombre(), StringComparison.OrdinalIgnoreCase);
		}

		public bool sosMenor(Alumno c, Alumno c2)
		{
			return string.Compare(c.getNombre(), c2.getNombre(), StringComparison.OrdinalIgnoreCase) > 0;
		}

		public bool sosMayor(Alumno c, Alumno c2)
		{
			return string.Compare(c.getNombre(), c2.getNombre(), StringComparison.OrdinalIgnoreCase) < 0;
		}
	}
}
