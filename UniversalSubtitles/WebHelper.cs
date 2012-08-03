using System;
using System.IO;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

namespace UniversalSubtitles
{
	internal static class WebHelper
	{
		public async static Task<T> Json<T>(string url)
        {
			WebClient client = new WebClient();
			var result = await client.DownloadDataTaskAsync(new Uri(url));
			
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
			
            var tcs = new TaskCompletionSource<T>();
            var request = (HttpWebRequest)WebRequest.Create(url);
            
            using (var stream = new MemoryStream(result))
            {
                var deserialized = serializer.ReadObject(stream);
                return (T) deserialized;
            }
		}
	}
}