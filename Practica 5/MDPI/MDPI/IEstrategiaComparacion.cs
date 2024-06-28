using System;

namespace MDPI
{
	public interface IEstrategiaComparacion
	{
		bool SosIgual(Alumno alumno, Alumno otroAlumno);
		bool SosMenor(Alumno alumno, Alumno otroAlumno);
		bool SosMayor(Alumno alumno, Alumno otroAlumno);
	}
}
