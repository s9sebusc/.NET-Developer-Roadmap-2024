using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
	internal class MusicPlayer
	{
		private IMusicPlayerState _state;

		public MusicPlayer()
		{
			_state = new StopState(); // Default State
		}

		public void SetState(IMusicPlayerState state)
		{
			_state = state;
		}

		public void Play()
		{
			_state.Play(this); // Execution of necessary algorithms for playing music
		}

		public void Pause()
		{
			_state.Pause(this); // Execution of necessary algorithms for stopping music player
		}

		public void Stop()
		{
			_state.Stop(this); // Execution of necessary algorithms for pausing music player
		}
	}
}
