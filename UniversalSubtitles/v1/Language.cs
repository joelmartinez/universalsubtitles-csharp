using System;
using System.Runtime.Serialization;

namespace UniversalSubtitles.v1
{
	/// <summary>
	/// Information about a Language available for a given video
	/// </summary>
	/// <remarks>    {
    ///    "id": 12,
    ///    "code": "it", 
    ///    "name": "Italian", 
    ///    "is_original": true
    /// }</remarks>
	[DataContract]
	public class Language
	{
		[DataMember(Name="completion")]
		public string Completion {get;set;}
		
		[DataMember(Name="id")]
		public string Id {get;set;}
		
		[DataMember(Name="code")]
		public string Code {get;set;}
		
		[DataMember(Name="name")]
		public string Name {get;set;}
		
		[DataMember(Name="is_original")]
		public bool IsOriginal {get;set;}
	}
}
