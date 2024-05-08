using System;

namespace MDP1
{
	public interface Iterador
	{
		void primero();
		void siguiente();
		bool fin();
		Iterado actual();
	}
}
