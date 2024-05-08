using System;

namespace MDP1
{
	public class CompararDni : CompararEstrategia
	{
		public bool sosIgual(Alumno c, Alumno c2)
		{
			return c.getDNI() == c2.getDNI();
		}

		public bool sosMenor(Alumno c, Alumno c2)
		{
			return c2.getDNI() < c.getDNI();
		}

		public bool sosMayor(Alumno c, Alumno c2)
		{
			return c2.getDNI() > c.getDNI();
		}
	}
}