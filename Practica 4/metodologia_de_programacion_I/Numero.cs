using System;

namespace metodologia_de_programacion_I
{
	public class Numero : Comparable
	{
		int valor;
		
		public Numero(int v)
		{
			this.valor = v;
		}
		
    public int getValor()
    {
        return this.valor;
    }
		
		public bool sosIgual(Comparable c){
			var temp = c as Numero;
			if(temp != null)
				return temp.getValor() == this.getValor();
			return false;
		}
		
		public bool sosMenor(Comparable c){
			var temp = c as Numero;
			if(temp != null)
				return temp.getValor() > this.getValor();
			return false;
		}
		
		public bool sosMayor(Comparable c){
			var temp = c as Numero;
			if(temp != null)
				return temp.getValor() < this.getValor();
			return false;
		}
	}
}
