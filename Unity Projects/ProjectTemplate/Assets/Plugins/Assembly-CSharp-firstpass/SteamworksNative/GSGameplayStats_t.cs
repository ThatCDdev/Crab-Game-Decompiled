using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 16)]
	public struct GSGameplayStats_t
	{
		public const int k_iCallback = 207;

		public EResult m_eResult;

		public int m_nRank;

		public uint m_unTotalConnects;

		public uint m_unTotalMinutesPlayed;
	}
}
