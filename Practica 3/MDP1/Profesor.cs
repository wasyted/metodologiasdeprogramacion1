using System;

namespace MDP1
{
	public class Profesor : Persona, Iterado
	{
		private int antiguedad;

		public Profesor(string n, int d, int a)
			: base(n, d)
		{
			this.antiguedad = a;
		}
		
		public int getAntiguedad()
		{
			return this.antiguedad;
		}

		public void hablarALaClase()
		{
			Console.WriteLine("Hablando de algún tema");
		}

		public void escribirEnElPizarron()
		{
			Console.WriteLine("Escribiendo en el pizarrón");
		}
		
		public override bool sosIgual(Comparable c)
		{
			Profesor otroProfe = (Profesor)c;
			return this.antiguedad == otroProfe.getAntiguedad();
		}

		public override bool sosMenor(Comparable c)
		{
			Profesor otroProfe = (Profesor)c;
			return this.antiguedad < otroProfe.getAntiguedad();
		}

		public override bool sosMayor(Comparable c)
		{
			Profesor otroProfe = (Profesor)c;
			return this.antiguedad > otroProfe.getAntiguedad();
		}
		
		public override string ToString()
		{
			return string.Format("[Profesor Nombre={2}, Antiguedad={0}, Dni={1}]", getAntiguedad(), getDNI(), getNombre());
		}
	}
}
