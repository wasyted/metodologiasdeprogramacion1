using system;

namespace MDP1
{
    public class AlumnoCompuesto : IAlumno 
    {
        private List<IAlumno> hijos;

        public void AlumnoCompuesto()
        {
            this.hijos = new List<Ialumnos>;
        }

        public void agregarHijo(Ialumno alumno)
        {
            this.hijos.Add(alumno);
        }
        //implementar Ialumno:

        public string getNombre()
        {
           foreach (Ialumno alumno in hijos)
           {
            string nombreAlumno = "\n";
            return nombreAlumno += alumno.getNombre() + "\n";
           } 
        }
    }
}

// clase alumno

public class Alumno : Ialumno 
{
    private string nombre = "Matías";
    public string getNombre()
    {
        return this.nombre;
    }
}