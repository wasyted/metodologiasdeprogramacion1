using System;
using MDPI;

namespace MetodologíasDeProgramaciónI
{
	public class AlumnoAdapter : Student
	{
		private IAlumno alumno;

		public AlumnoAdapter(IAlumno alumno)
		{
			this.alumno = alumno;
		}
		
		public int GetLegajo(){
			return this.alumno.GetLegajo();
		}
		
		public int GetCalificacion(){
			return this.alumno.GetCalificacion();
		}

		public string getName()
		{
			return this.alumno.GetNombre();
		}

		public int yourAnswerIs(int question)
		{
			return alumno.responderPregunta(question);
		}

		public void setScore(int score)
		{
			this.alumno.SetCalificacion(score);
		}

		public string showResult()
		{
			return alumno.mostrarCalificacion();
		}

		public bool equals(Student student)
		{
			return this.alumno.Equals(((AlumnoAdapter)student).alumno);
		}

		public bool lessThan(Student student)
		{
			return this.alumno.GetCalificacion() < ((AlumnoAdapter)student).alumno.GetCalificacion();
		}

		public bool greaterThan(Student student)
		{
			return this.alumno.GetCalificacion() > ((AlumnoAdapter)student).alumno.GetCalificacion();
		}
	}
}
