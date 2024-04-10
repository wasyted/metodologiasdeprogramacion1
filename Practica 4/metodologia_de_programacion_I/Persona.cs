namespace metodologia_de_programacion_I
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
            return this.nombre;
        }

        public int getDNI()
        {
            return this.dni;
        }

        public bool sosIgual(Comparable c)
        {
            Persona otraPersona = c as Persona;
            if (otraPersona != null)
            {
                return this.dni == otraPersona.getDNI();
            }
            return false;
        }

        public bool sosMenor(Comparable c)
        {
            Persona otraPersona = c as Persona;
            if (otraPersona != null)
            {
                return this.dni < otraPersona.getDNI();
            }
            return false;
        }

        public bool sosMayor(Comparable c)
        {
            Persona otraPersona = c as Persona;
            if (otraPersona != null)
            {
                return this.dni > otraPersona.getDNI();
            }
            return false;
        }
    }
}