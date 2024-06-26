using System;

namespace MDPI
{
	public interface IObservado
	{
		void agregarObservador(IObservador o);
	
		void quitarObservador(IObservador o);
	
		// avisa que algo cambió
		void notificar(string accion);
	}
}
