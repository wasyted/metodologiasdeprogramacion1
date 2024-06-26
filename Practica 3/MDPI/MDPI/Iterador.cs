using System;

namespace MDPI
{
	public interface Iterador
	{
		void Primero();
		void Siguiente();
		bool Fin();
		object Actual();
	}

}
