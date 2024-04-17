using System;

namespace MDP1
{
	public class Persona : Comparable
	{
		private string nombre;
		private int dni;
	
		public Persona(string n, int d)
		{
			this.nombre = n;
			this.dni = d;
		}
	
		public string getNombre()
		{
			return nombre;
		}
	
		public int getDNI()
		{
			return dni;
		}
	
		public virtual bool sosIgual(Comparable c)
		{
			Persona otraPersona = (Persona)c;
			return this.dni == otraPersona.getDNI();
		}
	
		public virtual bool sosMenor(Comparable c)
		{
			Persona otraPersona = (Persona)c;
			return this.dni < otraPersona.getDNI();
		}
	
		public virtual bool sosMayor(Comparable c)
		{
			Persona otraPersona = (Persona)c;
			return this.dni > otraPersona.getDNI();
		}
	}

}
