using System;

namespace MDP1
{
	public class CompararNombre : CompararEstrategia
	{
		public override bool sosIgual(Comparable c)
		{
			Alumno otroAlumno = (Alumno)c;
			return this.legajo == otroLegajo.getNombre();
		}

		public override bool sosMenor(Comparable c)
		{
			Alumno otroAlumno = (Alumno)c;
			return this.legajo < otroAlumno.getNombre();
		}

		public override bool sosMayor(Comparable c)
		{
			Alumno otroAlumno = (Alumno)c;
			return this.legajo > otroAlumno.getNombre();
		}
	}
}
