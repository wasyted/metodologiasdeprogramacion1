using System;

namespace MDPI
{
	public class ClaveValor : IComparable
	{
		public IComparable Clave { get; private set; }
		public Object Valor { get; private set; }

		public ClaveValor(IComparable clave, object valor)
		{
			Clave = clave;
			Valor = valor;
		}

		public void SetValor(object valor)
		{
			Valor = valor;
		}
		
		public Object GetValor()
		{
			return Valor;
		}
		
		public bool SosIgual(IComparable otro){
			ClaveValor otraClave = (ClaveValor)otro;
			return this.GetValor() == otraClave.GetValor();
		}
		
		public bool SosMayor(IComparable otro){
			return false;
		}
		
		public bool SosMenor(IComparable otro){
			return false;
		}
	}
}


