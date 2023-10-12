using System.Runtime.InteropServices;

namespace SteamworksNative
{
	[StructLayout(0, Pack = 8, Size = 16)]
	public struct HTML_StatusText_t
	{
		public const int k_iCallback = 4523;

		public HHTMLBrowser unBrowserHandle;

		public string pchMsg;
	}
}
