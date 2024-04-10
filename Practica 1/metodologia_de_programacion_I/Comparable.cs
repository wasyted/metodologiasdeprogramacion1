/*
Ejercicio 1
Implemente la siguiente interface que representa cualquier objeto que sabe compararse con
otro objeto de su “mismo tipo”:
Comparable
	sosIgual(Comparable)  Devuelve verdadero si el objeto
		que recibe el mensaje es el mismo que
		el “comparable” recibido por parámetro,
		devuelve falso en caso contrario
	sosMenor(Comparable)  Devuelve verdadero si el objeto
		que recibe el mensaje es más chico que
		el “comparable” recibido por parámetro,
		devuelve falso en caso contrario
	sosMayor(Comparable)  Devuelve verdadero si el objeto
		que recibe el mensaje es más grande que
		el “comparable” recibido por parámetro,
		devuelve falso en caso contrario 
 
*/

using System;

namespace metodologia_de_programacion_I
{
	public interface Comparable
	{
		bool sosIgual(Comparable c);
		bool sosMenor(Comparable c);
		bool sosMayor(Comparable c);
	}
}

