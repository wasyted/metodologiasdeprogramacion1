using System;

namespace MDPI
{
	public class Persona : IComparable
	{
		private string nombre;
		private int dni;

		public Persona(string n, int d)
		{
			nombre = n;
			dni = d;
		}

		public string GetNombre()
		{
			return nombre;
		}

		public int GetDNI()
		{
			return dni;
		}

		public virtual bool SosIgual(IComparable comparable)
		{
			
			Console.WriteLine("Hola desde la clase persona");
			Persona otra = comparable as Persona;
			return otra != null && dni == otra.dni;
		}

		public virtual bool SosMenor(IComparable comparable)
		{
			Persona otra = comparable as Persona;
			return otra != null && dni < otra.dni;
		}

		public virtual bool SosMayor(IComparable comparable)
		{
			Persona otra = comparable as Persona;
			return otra != null && dni > otra.dni;
		}
		
		public override string ToString()
		{
			return string.Format("[Persona Nombre={0}, Dni={1}]", this.GetNombre(), this.GetDNI());
		}
	}
}
