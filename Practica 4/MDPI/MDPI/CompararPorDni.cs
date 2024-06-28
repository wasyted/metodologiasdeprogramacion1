using System;

namespace MDPI
{
	public class CompararPorDni : IEstrategiaComparacion
	{
		public bool SosIgual(Alumno alumno, Alumno otroAlumno)
		{
			if (alumno.GetDNI() == otroAlumno.GetDNI()) {
				return true;
			}
			return false;
		}

		public bool SosMenor(Alumno alumno, Alumno otroAlumno)
		{
			if (alumno.GetDNI() < otroAlumno.GetDNI()) {
				return true;
			}
			return false;
		}

		public bool SosMayor(Alumno alumno, Alumno otroAlumno)
		{
			if (alumno.GetDNI() > otroAlumno.GetDNI()) {
				return true;
			}
			return false;
		}
	}
}
