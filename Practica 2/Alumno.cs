using System;

namespace metodologia_de_programacion_I
{
    public class Alumno : Persona, Comparable, IAlumno
    {
        private int legajo;
        private double promedio;
        private int calificacion;

        public Alumno(string n, int d, int l, double p) : base(n, d)
        {
            this.legajo = l;
            this.promedio = p;
        }

        public int getLegajo()
        {
            return this.legajo;
        }

        public double getPromedio()
        {
            return this.promedio;
        }
        
        public int getCalificacion(){
        	return this.calificacion;
        }
        
        public void setCalificacion(int c){
        	this.calificacion = c;
        }

        public new bool sosIgual(Comparable c)
        {
            Alumno otroAlumno = c as Alumno;
            if (otroAlumno != null)
            {
                return this.legajo == otroAlumno.getLegajo();
            }
            return false;
        }

        public new bool sosMenor(Comparable c)
        {
            Alumno otroAlumno = c as Alumno;
            if (otroAlumno != null)
            {
                return this.legajo < otroAlumno.getLegajo();
            }
            return false;
        }

        public new bool sosMayor(Comparable c)
        {
            Alumno otroAlumno = c as Alumno;
            if (otroAlumno != null)
            {
                return this.legajo > otroAlumno.getLegajo();
            }
            return false;
        }
        
        public int responderPregunta(int pregunta)
        {
        	Random random = new Random();
        	return respuesta = random.Next(1, 4);
        }
        
        public string mostrarCalificacion()
        {
        	return this.getNombre + "	" + this.getCalificacion;
        }
    }
}
