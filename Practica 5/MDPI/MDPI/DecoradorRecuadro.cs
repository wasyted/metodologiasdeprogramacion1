namespace MDPI
{
	public class DecoradorRecuadro : DecoradorAlumno
	{
		private IAlumno alumno;
				
		public DecoradorRecuadro(IAlumno a)
			: base(a)
		{
			this.alumno = a;
		}
    	
		public override string mostrarCalificacion()
		{
			string resultado = base.mostrarCalificacion();

			string border = new string('*', resultado.Length + 4);
			return border + "\n* " + resultado + " *\n" + border;
		}
	}
}

