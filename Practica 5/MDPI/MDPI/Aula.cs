using System;
using MetodologíasDeProgramaciónI;

namespace MDPI
{
	public class Aula
	{
		private Teacher teacher;

		public void comenzar()
		{
			Console.WriteLine("Iniciando la clase...");
			teacher = new Teacher();
		}

		public void nuevoAlumno(Student alumno)
		{
			if (teacher == null) {
				Console.WriteLine("Primero debe iniciar la clase con el método comenzar.");
				return;
			}
			
			Console.WriteLine("\n "+ alumno.getName() + " llega al aula...");
			teacher.goToClass(alumno);
		}

		public void claseLista()
		{
			if (teacher == null) {
				Console.WriteLine("Primero debe iniciar la clase con el método comenzar.");
				return;
			}
			Console.WriteLine("\nLa clase está llena. El profesor dá la clase...");
			teacher.teachingAClass();
		}
	}
}
