using System;
using System.Threading.Tasks;

namespace UniversalSubtitles.v1
{
	/// <summary>
	/// http://www.universalsubtitles.org/api/1.0/documentation/
	/// </summary>
	public class Api
	{
		public Api()
		{
		}
		
		/// <summary>
		/// Return subtitles for video.
		/// </summary>
		public async Task<SubtitleLine[]> Subtitles(string video_url)
		{
			string url = string.Format("https://www.universalsubtitles.org/api/1.0/subtitles/?video_url={0}", Uri.EscapeUriString(video_url));
			
			return await WebHelper.Json<SubtitleLine[]>(url);
		}
	}
}
