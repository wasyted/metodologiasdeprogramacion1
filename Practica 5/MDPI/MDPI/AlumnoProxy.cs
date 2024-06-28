using System;

namespace MDPI
{
	public class AlumnoProxy : Alumno
	{
		
		string nombre;
		int dni;
		int legajo;
		double promedio;
		Alumno alumno = null;
		
		public AlumnoProxy(string nombre, int dni, int legajo, double promedio)
			: base(nombre, dni, legajo, promedio)
		{
			this.nombre = nombre;
			this.dni = dni;
			this.legajo = legajo;
			this.promedio = promedio;
		}
		public override int responderPregunta(int pregunta)
		{
			CrearAlumno(this.nombre, this.dni, this.legajo, this.promedio);
			return this.alumno.responderPregunta(pregunta);
		}
		
		public Alumno CrearAlumno(string n, int d, int l, double p)
		{
			if (this.alumno == null) {
				Console.WriteLine("\nCreando instancia real del alumno...");
				this.alumno = new Alumno(n, d, l, p);
			}
			return alumno;
		}
	}
}