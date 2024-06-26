using System;

namespace MDPI
{
	public class CompararPorLegajo : IEstrategiaComparacion
	{
		public bool SosIgual(Alumno alumno, Alumno otroAlumno)
		{
			if (alumno.GetLegajo() == otroAlumno.GetLegajo()) {
				return true;
			}
			return false;
		}

		public bool SosMenor(Alumno alumno, Alumno otroAlumno)
		{
			if (alumno.GetLegajo() < otroAlumno.GetLegajo()) {
				return true;
			}
			return false;
		}

		public bool SosMayor(Alumno alumno, Alumno otroAlumno)
		{
			if (alumno.GetLegajo() > otroAlumno.GetLegajo()) {
				return true;
			}
			return false;
		}
	}
}