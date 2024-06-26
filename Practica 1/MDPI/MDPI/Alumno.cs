using System;

namespace MDPI
{
	public class Alumno : Persona
	{
		// Variables específicas de Alumno
		private int legajo;
		private double promedio;

		// Constructor que inicializa tanto las variables de Persona como las específicas de Alumno
		public Alumno(string n, int d, int l, double p)
			: base(n, d)
		{
			legajo = l;
			promedio = p;
		}

		// Método para obtener el legajo del alumno
		public int GetLegajo()
		{
			return legajo;
		}

		// Método para obtener el promedio del alumno
		public double GetPromedio()
		{
			return promedio;
		}
		
		
		public override bool SosIgual(IComparable comparable)
		{
			Alumno otroAlumno = (Alumno)comparable;
			return this.legajo == otroAlumno.GetLegajo();
		}

		public override bool SosMenor(IComparable comparable)
		{
			Alumno otroAlumno = (Alumno)comparable;
			return this.legajo < otroAlumno.GetLegajo();
		}

		public override bool SosMayor(IComparable comparable)
		{
			Alumno otroAlumno = (Alumno)comparable;
			return this.legajo > otroAlumno.GetLegajo();
		}
	}
}
