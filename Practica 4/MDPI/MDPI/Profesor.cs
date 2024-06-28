using System;
using System.Collections.Generic;

namespace MDPI
{
	public class Profesor : Persona, IObservado
	{
		private int antiguedad;
		private List<IObservador> observadores;

		public Profesor(string n, int d, int a)
			: base(n, d)
		{
			antiguedad = a;
			observadores = new List<IObservador>();
		}
		
		public void agregarObservador(IObservador o)
		{
			observadores.Add(o);
		}

		public void quitarObservador(IObservador o)
		{
			observadores.Remove(o);
		}

		public void notificar(string accion)
		{
			foreach (IObservador observador in observadores) {
				observador.actualizar(this, accion);
			}
		}

		public void HablarALaClase()
		{
			Console.WriteLine("\nProfe " + this.GetNombre() + ": Hablando de algún tema");
			notificar("hablar");
		}

		public void EscribirEnElPizarron()
		{
			Console.WriteLine("\nProfe " + this.GetNombre() + ": Escribiendo en el pizarrón");
			notificar("escribir");
		}

		public override string ToString()
		{
			string datosProfesor = " Antigüedad: " + antiguedad + " años";
			return base.ToString() + datosProfesor;
		}
	}
}
