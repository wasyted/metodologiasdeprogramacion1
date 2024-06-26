using System;
using System.Collections.Generic;

namespace MDPI
{
	public class Alumno : Persona, IObservador
	{
		private int legajo;
		private double promedio;
		private static Random random = new Random();
		private IEstrategiaComparacion estrategiaComparacion;
		private static List<string> frasesDistraccion = new List<string> {
			"Mirando el celular",
			"Dibujando en el margen de la carpeta",
			"Tirando aviones de papel"
		};

		public Alumno(string nombre, int dni, int legajo, double promedio)
			: base(nombre, dni)
		{
			this.legajo = legajo;
			this.promedio = promedio;
			this.estrategiaComparacion = new CompararPorNombre(); // Estrategia por defecto
		}

		public int GetLegajo()
		{
			return legajo;
		}

		public double GetPromedio()
		{
			return promedio;
		}

		public void PrestarAtencion()
		{
			Console.WriteLine(this.GetNombre() + ": Prestando atención");
		}

		public void Distraerse()
		{
			int index = random.Next(frasesDistraccion.Count);
			Console.WriteLine(this.GetNombre() + ": " +frasesDistraccion[index]);
		}

		public void actualizar(IObservado o, string accion)
		{
			if (o is Profesor) {
				if (accion == "hablar") {
					PrestarAtencion();
				} else if (accion == "escribir") {
					Distraerse();
				}
			}
		}

		public void SetEstrategiaDeComparacion(IEstrategiaComparacion estrategia)
		{
			this.estrategiaComparacion = estrategia;
		}
		
		public override string ToString()
		{
			return string.Format("[Alumno Nombre={3}, Legajo={0}, Promedio={1}, Dni={2}]", this.GetLegajo(), this.GetPromedio(), this.GetDNI(), this.GetNombre());
		}
	}
}



