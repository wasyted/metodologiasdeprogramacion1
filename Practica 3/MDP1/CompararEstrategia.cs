using System;

namespace MDP1
{
	public interface CompararEstrategia
	{
		bool sosIgual(Alumno c, Alumno c2);
		bool sosMayor(Alumno c, Alumno c2);
		bool sosMenor(Alumno c, Alumno c2);
	}
}
