using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
	internal class StopState : IMusicPlayerState
	{
		public void Play(MusicPlayer player)
		{
			Console.WriteLine("Starting player...");
			player.SetState(new PlayState());
		}

		public void Pause(MusicPlayer player)
		{
			Console.WriteLine("Pausing player...");
			player.SetState(new PauseState());
		}

		public void Stop(MusicPlayer player)
		{
			Console.WriteLine("Player is already stopped.");
		}
	}
}
