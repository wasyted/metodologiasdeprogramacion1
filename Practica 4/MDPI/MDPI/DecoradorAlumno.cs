using System;

namespace MDPI
{

	public abstract class DecoradorAlumno : IAlumno
	{
		private IAlumno alumno;
		
		public DecoradorAlumno(IAlumno a){
			this.alumno = a;
		}
		
		public int GetCalificacion(){
			return this.alumno.GetCalificacion();
		}
		
		public string GetNombre(){
			return this.alumno.GetNombre();
		}
		
		public int GetLegajo(){
			return this.alumno.GetLegajo();
		}
		
		public double GetPromedio(){
			return this.alumno.GetPromedio();
		}
		
		public virtual int responderPregunta(int pregunta){
			return this.alumno.responderPregunta(pregunta);
		}
		
		public virtual string mostrarCalificacion(){
			return this.alumno.mostrarCalificacion();
		}
		
		public override string ToString(){
			return this.alumno.ToString();
		}
		
		public void SetCalificacion(int calificacion){
			this.alumno.SetCalificacion(calificacion);
		}
	}
}
