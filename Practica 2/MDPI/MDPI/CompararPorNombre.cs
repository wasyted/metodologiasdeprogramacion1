using System;

namespace MDPI
{
	public class CompararPorNombre : IEstrategiaComparacion
	{
		public bool SosIgual(Alumno alumno, Alumno otroAlumno)
		{
			if (alumno.GetNombre()[0] == otroAlumno.GetNombre()[0]) {
				return true;
			}
			return false;
		}

		public bool SosMenor(Alumno alumno, Alumno otroAlumno)
		{
			if (alumno.GetNombre()[0] < otroAlumno.GetNombre()[0]) {
				return true;
			}
			return false;
		}

		public bool SosMayor(Alumno alumno, Alumno otroAlumno)
		{
			if (alumno.GetNombre()[0] > otroAlumno.GetNombre()[0]) {
				return true;
			}
			return false;
		}
	}
}
