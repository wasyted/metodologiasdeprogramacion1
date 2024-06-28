namespace MDPI
{
    public class DecoradorLegajo : DecoradorAlumno
    {
				private IAlumno alumno;
				
				public DecoradorLegajo(IAlumno a) : base(a){
					this.alumno = a;
				}
    	
        public override string mostrarCalificacion()
        {
        	string resultado = base.mostrarCalificacion();
        	
        	return resultado = resultado + " " + GetLegajo();
        }
    }
}
