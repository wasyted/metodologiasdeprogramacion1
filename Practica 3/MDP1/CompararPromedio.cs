using System;

namespace MDP1
{
    public class CompararPromedio : CompararEstrategia
    {
        public bool sosIgual(Alumno c , Alumno c2)
        {
        	return Math.Abs(c.getPromedio() - c2.getPromedio()) < double.Epsilon;
        }

        public bool sosMenor(Alumno c , Alumno c2)
        {
        	return c2.getPromedio() < c.getPromedio();
        }

        public bool sosMayor(Alumno c , Alumno c2)
        {
        	return c2.getPromedio() > c.getPromedio();
        }
    }
}
