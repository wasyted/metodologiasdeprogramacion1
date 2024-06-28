using System;

namespace MDPI
{
	public interface IObservador
	{
		void actualizar(IObservado o, string accion); //se entera del cambio
	}
}
