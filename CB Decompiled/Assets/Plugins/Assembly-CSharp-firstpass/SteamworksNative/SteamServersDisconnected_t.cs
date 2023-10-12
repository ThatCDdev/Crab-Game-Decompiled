using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 4)]
	public struct SteamServersDisconnected_t
	{
		public const int k_iCallback = 103;

		public EResult m_eResult;
	}
}
