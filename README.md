universalsubtitles-csharp
=========================

C# 5.0 API Wrapper for the [Universal Subtitles](http://www.universalsubtitles.org) service. 

Usage is simple:

```csharp
using UniversalSubtitles;
...
var api = new UniversalSubtitles.v1.Api();

string video_url = "http://www.youtube.com/watch?v=W0VWO4asgmk&feature=youtube_gdata_player";

SubtitleLine[] subtitles = await api.SubtitlesAsync(video_url);
// returns the subtitles in the video's spoken language
```
You can also give the user a list of available languages that are available for this video
```csharp
Language[] languages = await api.LanguagesAsync(video_url);
// display the list of available languages

SubtitleLine[] subtitles = await api.SubtitlesAsync(video_url, "it"); // or you can pass an instance of Language
```

This is being initially built to add subtitles to the [Khan Academy for Windows RT app](https://github.com/joelmartinez/Khan-Academy-for-WinRT) and initially supports only the [v1 API](http://www.universalsubtitles.org/api/1.0/documentation/) calls as that is what's being used by the [Khan Academy](http://khanacademy.org)