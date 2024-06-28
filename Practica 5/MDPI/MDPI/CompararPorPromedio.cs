using System;

namespace MDPI
{
	public class CompararPorPromedio : IEstrategiaComparacion
	{
		public bool SosIgual(Alumno alumno, Alumno otroAlumno)
		{
			if (alumno.GetPromedio() == otroAlumno.GetPromedio()) {
				return true;
			}
			return false;
		}

		public bool SosMenor(Alumno alumno, Alumno otroAlumno)
		{
			if (alumno.GetPromedio() < otroAlumno.GetPromedio()) {
				return true;
			}
			return false;
		}

		public bool SosMayor(Alumno alumno, Alumno otroAlumno)
		{
			if (alumno.GetPromedio() > otroAlumno.GetPromedio()) {
				return true;
			}
			return false;
		}
	}
}
