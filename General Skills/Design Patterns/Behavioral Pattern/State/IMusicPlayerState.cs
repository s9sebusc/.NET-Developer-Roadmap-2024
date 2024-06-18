using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
	internal interface IMusicPlayerState
	{
		void Play(MusicPlayer player);

		void Pause(MusicPlayer player);

		void Stop(MusicPlayer player);
	}
}
