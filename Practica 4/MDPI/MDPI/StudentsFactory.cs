using System;
using MetodologíasDeProgramaciónI;

namespace MDPI
{
	public class StudentsFactory : FabricaDeAlumnos
	{
		private int numeroOrden = 1;

		public Student crearAlumnoDecorado()
		{
			Alumno alumno = (Alumno)FabricaDeComparables.CrearAleatorio(2);
			AlumnoAdapter alumnoAdaptado = new AlumnoAdapter(alumno);

			numeroOrden++;
			return alumnoAdaptado;
		}
	}
}
