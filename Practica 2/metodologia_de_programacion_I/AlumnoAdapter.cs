using System;

namespace metodologia_de_programacion_I
{
	public class AlumnoAdapter : Student
	{
		IAlumno alumno;
		
		public AlumnoAdapter(Alumno a)
		{
			this.alumno = (IAlumno) a;
		}
		
		public string getName()
		{
			return alumno.getNombre();
		}
		
		public string showResult()
		{
			return alumno.mostrarCalificacion();
		}
		
		public int yourAnswerIs(int pregunta)
		{
			return alumno.responderPregunta();
		}
		
		public void setScore(int calificacion){
			alumno.setCalificacion();
		}
		
		public bool equals(Comparable c){
			return alumno.sosIgual 
		}
	}
}
