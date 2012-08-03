using System;
using System.Linq;
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
		/// Return subtitles for video for the default language.
		/// </summary>
		public async Task<SubtitleLine[]> Subtitles(string video_url)
		{
			return await Subtitles(video_url, string.Empty);
		}
		
		/// <summary>
		/// Return subtitles for video for the given language.
		/// </summary>
		public async Task<SubtitleLine[]> Subtitles(string video_url, Language language)
		{
			return await Subtitles(video_url, language.Code);
		}
		
		/// <summary>
		/// Return subtitles for video for the given language.
		/// </summary>
		public async Task<SubtitleLine[]> Subtitles(string video_url, string language)
		{
			string url = string.Format("https://www.universalsubtitles.org/api/1.0/subtitles/?video_url={0}", Uri.EscapeUriString(video_url));
			
			if (!string.IsNullOrWhiteSpace(language))
			{
				url = url += "&language=" + Uri.EscapeDataString(language);
			}
			
			return await WebHelper.Json<SubtitleLine[]>(url);
		}
		
		/// <summary>
		/// Return information about avilable subtitles languages that have a completion status of > 0.
		/// </summary>
		public async Task<Language[]> Languages(string video_url)
		{
			string url = string.Format("https://www.universalsubtitles.org/api/1.0/subtitles/languages/?video_url={0}", Uri.EscapeUriString(video_url));
			
			var languages = await WebHelper.Json<Language[]>(url);
			
			return languages
				.Where(l => l.Completion != "0%" && l.Completion != "0 Lines")
				.ToArray();
		}
	}
}
