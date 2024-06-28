using System;

namespace MDPI
{
	public interface IComparable
	{
		bool SosIgual(IComparable otro);
		bool SosMenor(IComparable otro);
		bool SosMayor(IComparable otro);
	}
}
