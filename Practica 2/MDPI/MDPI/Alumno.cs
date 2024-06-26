using System;

namespace MDPI
{
	public class Alumno : Persona
	{
		// Variables específicas de Alumno
		private int legajo;
		private double promedio;
		private IEstrategiaComparacion estrategiaComparacion;

		public Alumno(string nombre, int dni, int legajo, double promedio)
			: base(nombre, dni)
		{
			this.legajo = legajo;
			this.promedio = promedio;
			this.estrategiaComparacion = new CompararPorNombre(); // Estrategia por defecto
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
		
		public void SetEstrategiaDeComparacion(IEstrategiaComparacion estrategia)
		{
			this.estrategiaComparacion = estrategia;
		}
		
		public override bool SosIgual(IComparable comparable)
		{
			Alumno otroAlumno = (Alumno)comparable;
			return estrategiaComparacion.SosIgual((Alumno)this, otroAlumno);
		}

		public override bool SosMenor(IComparable comparable)
		{
			Alumno otroAlumno = (Alumno)comparable;
			return this.estrategiaComparacion.SosMenor((Alumno)this, otroAlumno);
		}

		public override bool SosMayor(IComparable comparable)
		{
			Alumno otroAlumno = (Alumno)comparable;
			return this.estrategiaComparacion.SosMayor((Alumno)this, otroAlumno);
		}
		
		public override string ToString()
		{
			return string.Format("[Alumno Nombre={3}, Legajo={0}, Promedio={1}, Dni={2}]", this.GetLegajo(), this.GetPromedio(), this.GetDNI(), this.GetNombre());
		}
	}
}
