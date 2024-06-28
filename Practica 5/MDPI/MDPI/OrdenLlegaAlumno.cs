using System;
using MetodologíasDeProgramaciónI;

namespace MDPI
{
	public class OrdenLlegaAlumno : OrdenEnAula2
	{
		private Aula aula;

		public OrdenLlegaAlumno(Aula aula)
		{
			this.aula = aula;
		}

		public void ejecutar(IComparable alumnoAdaptado)
		{
			AlumnoAdapter alumno = new AlumnoAdapter((IAlumno)alumnoAdaptado);
			aula.nuevoAlumno(alumno);
		}
	}

}
