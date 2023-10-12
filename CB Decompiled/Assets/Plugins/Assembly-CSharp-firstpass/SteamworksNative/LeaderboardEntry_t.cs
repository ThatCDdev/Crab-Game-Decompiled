using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 32)]
	public struct LeaderboardEntry_t
	{
		public CSteamID m_steamIDUser;

		public int m_nGlobalRank;

		public int m_nScore;

		public int m_cDetails;

		public UGCHandle_t m_hUGC;
	}
}
