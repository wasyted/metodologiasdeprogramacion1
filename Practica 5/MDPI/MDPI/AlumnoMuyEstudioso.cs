using System;

namespace MDPI
{
	public class AlumnoMuyEstudioso : Alumno
	{
		string nombre;
		int dni;
		int legajo;
		double promedio;
		
		public AlumnoMuyEstudioso(string nombre, int dni, int legajo, double promedio)
			: base(nombre, dni, legajo, promedio)
		{
			this.nombre = nombre;
			this.dni = dni;
			this.legajo = legajo;
			this.promedio = promedio;
		}
		public override int responderPregunta(int pregunta)
		{
			return pregunta % 3;
		}
	}
}
