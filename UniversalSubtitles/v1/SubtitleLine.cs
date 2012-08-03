using System;
using System.Runtime.Serialization;

namespace UniversalSubtitles.v1
{
	/// <summary>
	/// Represents a single subtitle
	/// </summary>
	/// <remarks>{
    ///     "subtitle_id": "8893438664714", 
    ///     "text": "Welcome to the\r\npresentation on limits.", 
    ///     "start_time": 0.90000000000000002, 
    ///     "end_time": 3.6099999999999999, 
    ///     "sub_order": 1.0, 
    ///     "start_of_paragraph": false
    /// }</remarks>
    [DataContract]
    public class SubtitleLine
	{
    	[DataMember(Name="subtitle_id")]
    	public string Id {get;set;}
    	
    	[DataMember(Name="text")]
    	public string Text {get;set;}
    	
    	[DataMember(Name="start_time")]
    	public decimal StartTime {get;set;}
    	
    	[DataMember(Name="end_time")]
    	public decimal EndTime {get;set;}
    	
    	[DataMember(Name="sub_order")]
    	public float SubOrder {get;set;}
    	
    	[DataMember(Name="start_of_paragraph")]
    	public bool IsStartOfParagraph {get;set;}
	}
}
