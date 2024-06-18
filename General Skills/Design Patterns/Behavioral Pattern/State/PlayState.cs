using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
	internal class PlayState : IMusicPlayerState
	{
		public void Play(MusicPlayer player)
		{
			Console.WriteLine("Player is already playing.");
		}

		public void Pause(MusicPlayer player)
		{
			Console.WriteLine("Pausing player...");
			player.SetState(new PauseState());
		}

		public void Stop(MusicPlayer player)
		{
			Console.WriteLine("Stopping player...");
			player.SetState(new StopState());
		}
	}
}
