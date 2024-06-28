namespace MDPI
{
	public class DecoradorPromocion : DecoradorAlumno
	{
		private IAlumno alumno;
				
		public DecoradorPromocion(IAlumno a)
			: base(a)
		{
			this.alumno = a;
		}
				
		private string ObtenerPromocion(int nota)
		{
			if (nota >= 7)
				return "PROMOCIÓN";
			else if (nota >= 4)
				return "APROBADO";
			else
				return "DESAPROBADO";
		}
    	
		public override string mostrarCalificacion()
		{
			string resultado = base.mostrarCalificacion();
        	
			return resultado = resultado + " " + ObtenerPromocion(this.alumno.GetCalificacion());
		}
	}
}



