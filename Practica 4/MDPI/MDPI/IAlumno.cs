using System;

namespace MDPI
{
	public interface IAlumno
	{
		void SetCalificacion(int calificacion);
		string GetNombre();
		int GetLegajo();
		double GetPromedio();
		int GetCalificacion();
		int responderPregunta(int pregunta);
		string mostrarCalificacion();
	}
}
