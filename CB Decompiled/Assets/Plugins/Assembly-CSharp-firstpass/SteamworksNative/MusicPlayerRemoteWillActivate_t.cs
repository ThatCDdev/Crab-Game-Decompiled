using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 1)]
	public struct MusicPlayerRemoteWillActivate_t
	{
		public const int k_iCallback = 4101;
	}
}
