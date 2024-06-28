namespace MDPI
{
	public class DecoradorNotaEnLetras : DecoradorAlumno
	{
		private IAlumno alumno;
				
		public DecoradorNotaEnLetras(IAlumno a)
			: base(a)
		{
			this.alumno = a;
		}
				
		private string ConvertirNotaEnLetras(int nota)
		{
			switch (nota) {
				case 1:
					return "(UNO)";
				case 2:
					return "(DOS)";
				case 3:
					return "(TRES)";
				case 4:
					return "(CUATRO)";
				case 5:
					return "(CINCO)";
				case 6:
					return "(SEIS)";
				case 7:
					return "(SIETE)";
				case 8:
					return "(OCHO)";
				case 9:
					return "(NUEVE)";
				case 10:
					return "(DIEZ)";
				default:
					return "";
			}
		}
    	
		public override string mostrarCalificacion()
		{
			string resultado = base.mostrarCalificacion();
        	
			return resultado = resultado + " " + ConvertirNotaEnLetras(this.alumno.GetCalificacion());
		}
	}
}
