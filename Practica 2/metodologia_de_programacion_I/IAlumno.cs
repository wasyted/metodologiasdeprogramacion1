using System;

namespace metodologia_de_programacion_I
{
	public interface IAlumno
	{
		string getNombre();
		double getCalificacion();
		int responderPregunta(int pregunta);
		string mostrarCalificacion();
	}
}
