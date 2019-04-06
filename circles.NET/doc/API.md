<a name='assembly'></a>
# circles.NET

## Types

- [APIBeatmap](#T-circles-NET-Models-APIBeatmap 'circles.NET.Models.APIBeatmap')
- [APIMultiplayerGame](#T-circles-NET-Models-APIMultiplayerGame 'circles.NET.Models.APIMultiplayerGame')
- [APIMultiplayerRoom](#T-circles-NET-Models-APIMultiplayerRoom 'circles.NET.Models.APIMultiplayerRoom')
- [APIMultiplayerRoomInfo](#T-circles-NET-Models-APIMultiplayerRoomInfo 'circles.NET.Models.APIMultiplayerRoomInfo')
- [APIReplay](#T-circles-NET-Models-APIReplay 'circles.NET.Models.APIReplay')
- [APIScore](#T-circles-NET-Models-APIScore 'circles.NET.Models.APIScore')
- [APIUser](#T-circles-NET-Models-APIUser 'circles.NET.Models.APIUser')
- [APIUserBest](#T-circles-NET-Models-APIUserBest 'circles.NET.Models.APIUserBest')
- [APIUserRecent](#T-circles-NET-Models-APIUserRecent 'circles.NET.Models.APIUserRecent')
- [CirclesAPIClient](#T-circles-NET-CirclesAPIClient 'circles.NET.CirclesAPIClient')
  - [Constructor(apiKey)](#M-circles-NET-CirclesAPIClient-#ctor-System-String- 'circles.NET.CirclesAPIClient.#ctor(System.String)')
  - [APIKey](#P-circles-NET-CirclesAPIClient-APIKey 'circles.NET.CirclesAPIClient.APIKey')
  - [BaseEndpoint](#P-circles-NET-CirclesAPIClient-BaseEndpoint 'circles.NET.CirclesAPIClient.BaseEndpoint')
  - [Client](#P-circles-NET-CirclesAPIClient-Client 'circles.NET.CirclesAPIClient.Client')
  - [CreateURL(endpoint,queryStrings)](#M-circles-NET-CirclesAPIClient-CreateURL-System-String,System-Object[]- 'circles.NET.CirclesAPIClient.CreateURL(System.String,System.Object[])')
  - [GetBeatmapsByIdAsync(beatmap_id,since,creator,gamemode,includeConversions,hash,limit)](#M-circles-NET-CirclesAPIClient-GetBeatmapsByIdAsync-System-Nullable{System-Int64},System-Nullable{System-DateTime},System-String,System-Nullable{circles-NET-Enums-Gamemode},System-Nullable{circles-NET-Enums-Conversions},System-String,System-Nullable{System-Int32}- 'circles.NET.CirclesAPIClient.GetBeatmapsByIdAsync(System.Nullable{System.Int64},System.Nullable{System.DateTime},System.String,System.Nullable{circles.NET.Enums.Gamemode},System.Nullable{circles.NET.Enums.Conversions},System.String,System.Nullable{System.Int32})')
  - [GetBeatmapsByMapsetAsync(mapset_id,since,creator,gamemode,includeConversions,hash,limit)](#M-circles-NET-CirclesAPIClient-GetBeatmapsByMapsetAsync-System-Nullable{System-Int64},System-Nullable{System-DateTime},System-String,System-Nullable{circles-NET-Enums-Gamemode},System-Nullable{circles-NET-Enums-Conversions},System-String,System-Nullable{System-Int32}- 'circles.NET.CirclesAPIClient.GetBeatmapsByMapsetAsync(System.Nullable{System.Int64},System.Nullable{System.DateTime},System.String,System.Nullable{circles.NET.Enums.Gamemode},System.Nullable{circles.NET.Enums.Conversions},System.String,System.Nullable{System.Int32})')
  - [GetMultiplayerRoomsAsync(roomId)](#M-circles-NET-CirclesAPIClient-GetMultiplayerRoomsAsync-System-Int64- 'circles.NET.CirclesAPIClient.GetMultiplayerRoomsAsync(System.Int64)')
  - [GetRawAsync\<T>\(endPoint,queryStrings)](#M-circles-NET-CirclesAPIClient-GetRawAsync``1-System-String,System-Object[]- 'circles.NET.CirclesAPIClient.GetRawAsync``1(System.String,System.Object[])')
  - [GetReplayAsync(username,beatmapId,mode)](#M-circles-NET-CirclesAPIClient-GetReplayAsync-System-String,System-Int64,circles-NET-Enums-Gamemode- 'circles.NET.CirclesAPIClient.GetReplayAsync(System.String,System.Int64,circles.NET.Enums.Gamemode)')
  - [GetScoresAsync(beatmapId,username,mode,mods,limit)](#M-circles-NET-CirclesAPIClient-GetScoresAsync-System-Int64,System-String,circles-NET-Enums-Gamemode,System-Nullable{circles-NET-Enums-Mods},System-Nullable{System-Int32}- 'circles.NET.CirclesAPIClient.GetScoresAsync(System.Int64,System.String,circles.NET.Enums.Gamemode,System.Nullable{circles.NET.Enums.Mods},System.Nullable{System.Int32})')
  - [GetUserBestAsync(username,mode,limit)](#M-circles-NET-CirclesAPIClient-GetUserBestAsync-System-String,circles-NET-Enums-Gamemode,System-Nullable{System-Int32}- 'circles.NET.CirclesAPIClient.GetUserBestAsync(System.String,circles.NET.Enums.Gamemode,System.Nullable{System.Int32})')
  - [GetUserRecentAsync(username,mode,limit)](#M-circles-NET-CirclesAPIClient-GetUserRecentAsync-System-String,circles-NET-Enums-Gamemode,System-Nullable{System-Int32}- 'circles.NET.CirclesAPIClient.GetUserRecentAsync(System.String,circles.NET.Enums.Gamemode,System.Nullable{System.Int32})')
  - [GetUsersAsync(name,mode)](#M-circles-NET-CirclesAPIClient-GetUsersAsync-System-String,circles-NET-Enums-Gamemode- 'circles.NET.CirclesAPIClient.GetUsersAsync(System.String,circles.NET.Enums.Gamemode)')
  - [GetUsersAsync(name,mode)](#M-circles-NET-CirclesAPIClient-GetUsersAsync-System-Int32,circles-NET-Enums-Gamemode- 'circles.NET.CirclesAPIClient.GetUsersAsync(System.Int32,circles.NET.Enums.Gamemode)')
- [CirclesHttpClient](#T-circles-NET-HTTP-CirclesHttpClient 'circles.NET.HTTP.CirclesHttpClient')

<a name='T-circles-NET-Models-APIBeatmap'></a>
## APIBeatmap `type`

##### Namespace

circles.NET.Models

##### Summary

A class representing an osu! beatmap returned by API

<a name='P-circles-NET-Models-APIBeatmap-AR'></a>
### AR `property`

##### Summary

Approach Rate

<a name='P-circles-NET-Models-APIBeatmap-ApprovedDate'></a>
### ApprovedDate `property`

##### Summary

The date this beatmap was approved

<a name='P-circles-NET-Models-APIBeatmap-ApprovedStatus'></a>
### ApprovedStatus `property`

##### Summary

The [ApprovedStatus](#P-circles-NET-Models-APIBeatmap-ApprovedStatus 'circles.NET.Models.APIBeatmap.ApprovedStatus') of this beatmap

<a name='P-circles-NET-Models-APIBeatmap-Artist'></a>
### Artist `property`

##### Summary

Compositor of the beatmap's music

<a name='P-circles-NET-Models-APIBeatmap-BeatmapId'></a>
### BeatmapId `property`

##### Summary

The ID of this beatmap

<a name='P-circles-NET-Models-APIBeatmap-Bpm'></a>
### Bpm `property`

##### Summary

BPM of the beatmap

<a name='P-circles-NET-Models-APIBeatmap-CS'></a>
### CS `property`

##### Summary

Circle Size

<a name='P-circles-NET-Models-APIBeatmap-Creator'></a>
### Creator `property`

##### Summary

Creator of the beatmap

<a name='P-circles-NET-Models-APIBeatmap-Difficulty'></a>
### Difficulty `property`

##### Summary

The name of this beatmap's difficulty

<a name='P-circles-NET-Models-APIBeatmap-FavouriteCount'></a>
### FavouriteCount `property`

##### Summary

Number of times this beatmap has been favourited

<a name='P-circles-NET-Models-APIBeatmap-Gamemode'></a>
### Gamemode `property`

##### Summary

The gamemode of this beatmap

<a name='P-circles-NET-Models-APIBeatmap-Genre'></a>
### Genre `property`

##### Summary

Genre of the beatmap

<a name='P-circles-NET-Models-APIBeatmap-HP'></a>
### HP `property`

##### Summary

HP Drain

<a name='P-circles-NET-Models-APIBeatmap-Language'></a>
### Language `property`

##### Summary

Language of the beatmap

<a name='P-circles-NET-Models-APIBeatmap-LastUpdate'></a>
### LastUpdate `property`

##### Summary

The date this beatmap was last updated

<a name='P-circles-NET-Models-APIBeatmap-MD5'></a>
### MD5 `property`

##### Summary

The MD5 hash of this beatmap

<a name='P-circles-NET-Models-APIBeatmap-MapsetId'></a>
### MapsetId `property`

##### Summary

The ID of the mapset this beatmap belongs to

<a name='P-circles-NET-Models-APIBeatmap-MaxCombo'></a>
### MaxCombo `property`

##### Summary

The max achievable combo on this map

<a name='P-circles-NET-Models-APIBeatmap-OD'></a>
### OD `property`

##### Summary

Overall Difficulty

<a name='P-circles-NET-Models-APIBeatmap-Passcount'></a>
### Passcount `property`

##### Summary

Number of times people passed this beatmap

<a name='P-circles-NET-Models-APIBeatmap-PlaybableLength'></a>
### PlaybableLength `property`

##### Summary

The playable length (in seconds) of this beatmap

<a name='P-circles-NET-Models-APIBeatmap-Playcount'></a>
### Playcount `property`

##### Summary

Number of times this beamap has been played

<a name='P-circles-NET-Models-APIBeatmap-Source'></a>
### Source `property`

##### Summary

Source of the beatmap's music

<a name='P-circles-NET-Models-APIBeatmap-StarRating'></a>
### StarRating `property`

##### Summary

The difficulty star rating of this beatmap

<a name='P-circles-NET-Models-APIBeatmap-Tags'></a>
### Tags `property`

##### Summary

Tags of the beatmap

<a name='P-circles-NET-Models-APIBeatmap-Title'></a>
### Title `property`

##### Summary

Title name of the beatmap's music

<a name='P-circles-NET-Models-APIBeatmap-TotalLength'></a>
### TotalLength `property`

##### Summary

The total length (in seconds) of this beatmap

<a name='T-circles-NET-Models-APIMultiplayerGame'></a>
## APIMultiplayerGame `type`

##### Namespace

circles.NET.Models

##### Summary

A class representing an osu! ongoing or finished multiplayer game returned by API

<a name='P-circles-NET-Models-APIMultiplayerGame-BeatmapId'></a>
### BeatmapId `property`

##### Summary

The ID of the beatmap (NOT BeatmapSet) currently played

<a name='P-circles-NET-Models-APIMultiplayerGame-EndTime'></a>
### EndTime `property`

##### Summary

The time at which this game ended (can be null if it's ongoing)

<a name='P-circles-NET-Models-APIMultiplayerGame-GameId'></a>
### GameId `property`

##### Summary

The ID of this game

<a name='P-circles-NET-Models-APIMultiplayerGame-Gamemode'></a>
### Gamemode `property`

##### Summary

The gamemode in which this beatmap is played in

<a name='P-circles-NET-Models-APIMultiplayerGame-Mods'></a>
### Mods `property`

##### Summary

Mods combination for this game

<a name='P-circles-NET-Models-APIMultiplayerGame-Scores'></a>
### Scores `property`

##### Summary

List of [APIScore](#T-circles-NET-Models-APIScore 'circles.NET.Models.APIScore')s for all people who played during this game

<a name='P-circles-NET-Models-APIMultiplayerGame-StartTime'></a>
### StartTime `property`

##### Summary

The time at which this game began

<a name='T-circles-NET-Models-APIMultiplayerRoom'></a>
## APIMultiplayerRoom `type`

##### Namespace

circles.NET.Models

##### Summary

A class representing an osu! ongoing or finished multiplayer room returned by API

<a name='P-circles-NET-Models-APIMultiplayerRoom-Games'></a>
### Games `property`

##### Summary

List of pasts and ongoing games

<a name='P-circles-NET-Models-APIMultiplayerRoom-Info'></a>
### Info `property`

##### Summary

Info about this [APIMultiplayerRoom](#T-circles-NET-Models-APIMultiplayerRoom 'circles.NET.Models.APIMultiplayerRoom')

<a name='T-circles-NET-Models-APIMultiplayerRoomInfo'></a>
## APIMultiplayerRoomInfo `type`

##### Namespace

circles.NET.Models

##### Summary

Information about an ongoing or finished [APIMultiplayerRoom](#T-circles-NET-Models-APIMultiplayerRoom 'circles.NET.Models.APIMultiplayerRoom')

<a name='P-circles-NET-Models-APIMultiplayerRoomInfo-EndTime'></a>
### EndTime `property`

##### Summary

The time at which this room was deleted (can be null if it's still ongoing)

<a name='P-circles-NET-Models-APIMultiplayerRoomInfo-MatchId'></a>
### MatchId `property`

##### Summary

The ID of this multiplayer room

<a name='P-circles-NET-Models-APIMultiplayerRoomInfo-Name'></a>
### Name `property`

##### Summary

The display name of this multiplayer room

<a name='P-circles-NET-Models-APIMultiplayerRoomInfo-StartTime'></a>
### StartTime `property`

##### Summary

The time at which this room was created

<a name='T-circles-NET-Models-APIReplay'></a>
## APIReplay `type`

##### Namespace

circles.NET.Models

##### Summary

A class representing replay data returned by API

<a name='T-circles-NET-Models-APIScore'></a>
## APIScore `type`

##### Namespace

circles.NET.Models

##### Summary

A class representing an osu! score returned from API

<a name='P-circles-NET-Models-APIScore-Count100s'></a>
### Count100s `property`

##### Summary

Number of 100s hits

<a name='P-circles-NET-Models-APIScore-Count300s'></a>
### Count300s `property`

##### Summary

Number of 300s hits

<a name='P-circles-NET-Models-APIScore-Count50s'></a>
### Count50s `property`

##### Summary

Number of 50s hits

<a name='P-circles-NET-Models-APIScore-CountGeki'></a>
### CountGeki `property`

##### Summary

Number of gekis hits

<a name='P-circles-NET-Models-APIScore-CountKatu'></a>
### CountKatu `property`

##### Summary

Number of katus hits

<a name='P-circles-NET-Models-APIScore-CountMisses'></a>
### CountMisses `property`

##### Summary

Number of missed hits

<a name='P-circles-NET-Models-APIScore-Date'></a>
### Date `property`

##### Summary

The date on which this score was achieved

<a name='P-circles-NET-Models-APIScore-ID'></a>
### ID `property`

##### Summary

The ID of this score

<a name='P-circles-NET-Models-APIScore-MaxCombo'></a>
### MaxCombo `property`

##### Summary

Max combo achieved in this score

<a name='P-circles-NET-Models-APIScore-Mods'></a>
### Mods `property`

##### Summary

Mods enabled for this score

<a name='P-circles-NET-Models-APIScore-Perfect'></a>
### Perfect `property`

##### Summary

A bool indicating whether this score is a perfect

<a name='P-circles-NET-Models-APIScore-Pp'></a>
### Pp `property`

##### Summary

The pp awarded for this score

<a name='P-circles-NET-Models-APIScore-Rank'></a>
### Rank `property`

##### Summary

The grade achieved on this score

<a name='P-circles-NET-Models-APIScore-Score'></a>
### Score `property`

##### Summary

Total score awarded on this map

<a name='P-circles-NET-Models-APIScore-UserId'></a>
### UserId `property`

##### Summary

The UserID of the player who achieved this score

<a name='P-circles-NET-Models-APIScore-Username'></a>
### Username `property`

##### Summary

Username of the played who achieved the score

<a name='T-circles-NET-Models-APIUser'></a>
## APIUser `type`

##### Namespace

circles.NET.Models

##### Summary

A class representing an osu! user returned from API

<a name='P-circles-NET-Models-APIUser-Accuracy'></a>
### Accuracy `property`

##### Summary

Accuracy of this player

<a name='P-circles-NET-Models-APIUser-Count100'></a>
### Count100 `property`

##### Summary

Total 100s hits

<a name='P-circles-NET-Models-APIUser-Count300'></a>
### Count300 `property`

##### Summary

Total 300s hits

<a name='P-circles-NET-Models-APIUser-Count50'></a>
### Count50 `property`

##### Summary

Total 50s hits

<a name='P-circles-NET-Models-APIUser-CountRankA'></a>
### CountRankA `property`

##### Summary

Total number of As

<a name='P-circles-NET-Models-APIUser-CountRankS'></a>
### CountRankS `property`

##### Summary

Total number of Ses

<a name='P-circles-NET-Models-APIUser-CountRankSS'></a>
### CountRankSS `property`

##### Summary

Total number of SSes

<a name='P-circles-NET-Models-APIUser-Country'></a>
### Country `property`

##### Summary

Player's country code

<a name='P-circles-NET-Models-APIUser-Level'></a>
### Level `property`

##### Summary

Level of this player

<a name='P-circles-NET-Models-APIUser-Playcount'></a>
### Playcount `property`

##### Summary

Playcount

<a name='P-circles-NET-Models-APIUser-PpCountryRank'></a>
### PpCountryRank `property`

##### Summary

Player's rank in his country leaderboard

<a name='P-circles-NET-Models-APIUser-PpRank'></a>
### PpRank `property`

##### Summary

Player's Rank in global leaderboard

<a name='P-circles-NET-Models-APIUser-PpRaw'></a>
### PpRaw `property`

##### Summary

Raw PP of this player

<a name='P-circles-NET-Models-APIUser-RankedScore'></a>
### RankedScore `property`

##### Summary

Total ranked score

<a name='P-circles-NET-Models-APIUser-TotalScore'></a>
### TotalScore `property`

##### Summary

Total (unranked) score

<a name='P-circles-NET-Models-APIUser-UserId'></a>
### UserId `property`

##### Summary

The UserID for this user

<a name='P-circles-NET-Models-APIUser-Username'></a>
### Username `property`

##### Summary

The username of this user

<a name='T-circles-NET-Models-APIUserBest'></a>
## APIUserBest `type`

##### Namespace

circles.NET.Models

##### Summary

A class representing an osu! score from one of player top scores

<a name='P-circles-NET-Models-APIUserBest-BeatmapId'></a>
### BeatmapId `property`

##### Summary

The ID of the beatmap (not BeatmapSet) this score was achieved on

<a name='P-circles-NET-Models-APIUserBest-Count100s'></a>
### Count100s `property`

##### Summary

Number of 100s hits

<a name='P-circles-NET-Models-APIUserBest-Count300s'></a>
### Count300s `property`

##### Summary

Number of 300s hits

<a name='P-circles-NET-Models-APIUserBest-Count50s'></a>
### Count50s `property`

##### Summary

Number of 50s hits

<a name='P-circles-NET-Models-APIUserBest-CountGeki'></a>
### CountGeki `property`

##### Summary

Number of gekis hits

<a name='P-circles-NET-Models-APIUserBest-CountKatu'></a>
### CountKatu `property`

##### Summary

Number of katus hits

<a name='P-circles-NET-Models-APIUserBest-CountMisses'></a>
### CountMisses `property`

##### Summary

Number of missed hits

<a name='P-circles-NET-Models-APIUserBest-Date'></a>
### Date `property`

##### Summary

The date on which this score was achieved

<a name='P-circles-NET-Models-APIUserBest-MaxCombo'></a>
### MaxCombo `property`

##### Summary

Max combo achieved in this score

<a name='P-circles-NET-Models-APIUserBest-Mods'></a>
### Mods `property`

##### Summary

Mods enabled for this score

<a name='P-circles-NET-Models-APIUserBest-Perfect'></a>
### Perfect `property`

##### Summary

A bool indicating whether this score is a perfect

<a name='P-circles-NET-Models-APIUserBest-Pp'></a>
### Pp `property`

##### Summary

The pp awarded for this score

<a name='P-circles-NET-Models-APIUserBest-Rank'></a>
### Rank `property`

##### Summary

The grade achieved on this score

<a name='P-circles-NET-Models-APIUserBest-Score'></a>
### Score `property`

##### Summary

Total score awarded on this map

<a name='P-circles-NET-Models-APIUserBest-UserId'></a>
### UserId `property`

##### Summary

The UserID of the player who achieved this score

<a name='T-circles-NET-Models-APIUserRecent'></a>
## APIUserRecent `type`

##### Namespace

circles.NET.Models

##### Summary

A class representing an osu! score from a play done recently returned by API

<a name='P-circles-NET-Models-APIUserRecent-Accuracy'></a>
### Accuracy `property`

##### Summary

The accuracy for this score

<a name='P-circles-NET-Models-APIUserRecent-BeatmapId'></a>
### BeatmapId `property`

##### Summary

The ID of the beatmap (not beatmapSet) this score was achieved on

<a name='P-circles-NET-Models-APIUserRecent-Count100s'></a>
### Count100s `property`

##### Summary

Number of 100s hits

<a name='P-circles-NET-Models-APIUserRecent-Count300s'></a>
### Count300s `property`

##### Summary

Number of 300s hits

<a name='P-circles-NET-Models-APIUserRecent-Count50s'></a>
### Count50s `property`

##### Summary

Number of 50s hits

<a name='P-circles-NET-Models-APIUserRecent-CountGeki'></a>
### CountGeki `property`

##### Summary

Number of gekis hits

<a name='P-circles-NET-Models-APIUserRecent-CountKatu'></a>
### CountKatu `property`

##### Summary

Number of katus hits

<a name='P-circles-NET-Models-APIUserRecent-CountMisses'></a>
### CountMisses `property`

##### Summary

Number of missed hits

<a name='P-circles-NET-Models-APIUserRecent-Date'></a>
### Date `property`

##### Summary

The date on which this score was achieved

<a name='P-circles-NET-Models-APIUserRecent-MaxCombo'></a>
### MaxCombo `property`

##### Summary

Max combo achieved in this score

<a name='P-circles-NET-Models-APIUserRecent-Mods'></a>
### Mods `property`

##### Summary

Mods enabled for this score

<a name='P-circles-NET-Models-APIUserRecent-Perfect'></a>
### Perfect `property`

##### Summary

A bool indicating whether this score is a perfect

<a name='P-circles-NET-Models-APIUserRecent-Pp'></a>
### Pp `property`

##### Summary

The pp awarded for this score

<a name='P-circles-NET-Models-APIUserRecent-Rank'></a>
### Rank `property`

##### Summary

The grade achieved on this score (can be F if player didn't completed the whole map)

<a name='P-circles-NET-Models-APIUserRecent-Score'></a>
### Score `property`

##### Summary

Total score awarded on this map

<a name='P-circles-NET-Models-APIUserRecent-UserId'></a>
### UserId `property`

##### Summary

The UserID of the player who achieved this score

<a name='T-circles-NET-CirclesAPIClient'></a>
## CirclesAPIClient `type`

##### Namespace

circles.NET

##### Summary

An asynchronous client wrapper class for the osu! api v1

<a name='M-circles-NET-CirclesAPIClient-#ctor-System-String-'></a>
### Constructor(apiKey) `constructor`

##### Summary

Constructs an instance of [CirclesAPIClient](#T-circles-NET-CirclesAPIClient 'circles.NET.CirclesAPIClient') with the API key given as parameter

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| apiKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-circles-NET-CirclesAPIClient-APIKey'></a>
### APIKey `property`

##### Summary

Gets or sets the API Key for this [CirclesAPIClient](#T-circles-NET-CirclesAPIClient 'circles.NET.CirclesAPIClient') instance

<a name='P-circles-NET-CirclesAPIClient-BaseEndpoint'></a>
### BaseEndpoint `property`

##### Summary

The defaut address to which API requests are made.

Override this if you need to pass API requests to eg: Ripple API

<a name='P-circles-NET-CirclesAPIClient-Client'></a>
### Client `property`

##### Summary

Gets the underlying [CirclesHttpClient](#T-circles-NET-HTTP-CirclesHttpClient 'circles.NET.HTTP.CirclesHttpClient') Http client backing this [CirclesAPIClient](#T-circles-NET-CirclesAPIClient 'circles.NET.CirclesAPIClient') instance

<a name='M-circles-NET-CirclesAPIClient-CreateURL-System-String,System-Object[]-'></a>
### CreateURL(endpoint,queryStrings) `method`

##### Summary

Returns a complete URL to the API

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpoint | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The endpoint |
| queryStrings | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | The query strings |

<a name='M-circles-NET-CirclesAPIClient-GetBeatmapsByIdAsync-System-Nullable{System-Int64},System-Nullable{System-DateTime},System-String,System-Nullable{circles-NET-Enums-Gamemode},System-Nullable{circles-NET-Enums-Conversions},System-String,System-Nullable{System-Int32}-'></a>
### GetBeatmapsByIdAsync(beatmap_id,since,creator,gamemode,includeConversions,hash,limit) `method`

##### Summary

Gets a list of beatmaps matching the given beatmapId and parameters asynchronously

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| beatmap_id | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int64}') |  |
| since | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') |  |
| creator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| gamemode | [System.Nullable{circles.NET.Enums.Gamemode}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{circles.NET.Enums.Gamemode}') |  |
| includeConversions | [System.Nullable{circles.NET.Enums.Conversions}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{circles.NET.Enums.Conversions}') |  |
| hash | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') |  |

<a name='M-circles-NET-CirclesAPIClient-GetBeatmapsByMapsetAsync-System-Nullable{System-Int64},System-Nullable{System-DateTime},System-String,System-Nullable{circles-NET-Enums-Gamemode},System-Nullable{circles-NET-Enums-Conversions},System-String,System-Nullable{System-Int32}-'></a>
### GetBeatmapsByMapsetAsync(mapset_id,since,creator,gamemode,includeConversions,hash,limit) `method`

##### Summary

Gets a list of beatmaps matching the given mapsetId and parameters asynchronously

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mapset_id | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int64}') | The mapset id (required) |
| since | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') |  |
| creator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| gamemode | [System.Nullable{circles.NET.Enums.Gamemode}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{circles.NET.Enums.Gamemode}') |  |
| includeConversions | [System.Nullable{circles.NET.Enums.Conversions}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{circles.NET.Enums.Conversions}') |  |
| hash | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') |  |

<a name='M-circles-NET-CirclesAPIClient-GetMultiplayerRoomsAsync-System-Int64-'></a>
### GetMultiplayerRoomsAsync(roomId) `method`

##### Summary

Gets data about a multiplayer room asynchronously

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| roomId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The Room Id |

<a name='M-circles-NET-CirclesAPIClient-GetRawAsync``1-System-String,System-Object[]-'></a>
### GetRawAsync\<T>\(endPoint,queryStrings) `method`

##### Summary

Performs a custom request against the given end_point with custom queryStrings

NOTE that the queryStrings already contains APIKey by default

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endPoint | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| queryStrings | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-circles-NET-CirclesAPIClient-GetReplayAsync-System-String,System-Int64,circles-NET-Enums-Gamemode-'></a>
### GetReplayAsync(username,beatmapId,mode) `method`

##### Summary

Gets replay data from a specific play from a specific user asynchronously

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| beatmapId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| mode | [circles.NET.Enums.Gamemode](#T-circles-NET-Enums-Gamemode 'circles.NET.Enums.Gamemode') |  |

<a name='M-circles-NET-CirclesAPIClient-GetScoresAsync-System-Int64,System-String,circles-NET-Enums-Gamemode,System-Nullable{circles-NET-Enums-Mods},System-Nullable{System-Int32}-'></a>
### GetScoresAsync(beatmapId,username,mode,mods,limit) `method`

##### Summary

Gets a list of scores for the given beatmap id matching given parameters asynchronously

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| beatmapId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The beatmap id to return scores from |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the user to return score from ([](#!-null 'null') by default) |
| mode | [circles.NET.Enums.Gamemode](#T-circles-NET-Enums-Gamemode 'circles.NET.Enums.Gamemode') | The gamemode (defaults to [Standard](#F-circles-NET-Enums-Gamemode-Standard 'circles.NET.Enums.Gamemode.Standard')) |
| mods | [System.Nullable{circles.NET.Enums.Mods}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{circles.NET.Enums.Mods}') | A mods bitflag (defaults to null) |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | A limit of results to return (returns first 500 results by default) |

<a name='M-circles-NET-CirclesAPIClient-GetUserBestAsync-System-String,circles-NET-Enums-Gamemode,System-Nullable{System-Int32}-'></a>
### GetUserBestAsync(username,mode,limit) `method`

##### Summary

Gets a list of top plays for the given username asynchronously

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The username of the player to return top plays from |
| mode | [circles.NET.Enums.Gamemode](#T-circles-NET-Enums-Gamemode 'circles.NET.Enums.Gamemode') | The gamemode (defaults to [Standard](#F-circles-NET-Enums-Gamemode-Standard 'circles.NET.Enums.Gamemode.Standard')) |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | A limit of results to return (returns first 500 results by default) |

<a name='M-circles-NET-CirclesAPIClient-GetUserRecentAsync-System-String,circles-NET-Enums-Gamemode,System-Nullable{System-Int32}-'></a>
### GetUserRecentAsync(username,mode,limit) `method`

##### Summary

Gets a list of recent plays for the given username asynchronously

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The username of the player to return recent plays from |
| mode | [circles.NET.Enums.Gamemode](#T-circles-NET-Enums-Gamemode 'circles.NET.Enums.Gamemode') | The gamemode (defaults to [Standard](#F-circles-NET-Enums-Gamemode-Standard 'circles.NET.Enums.Gamemode.Standard')) |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | A limit of results to return (returns first 500 results by default) |

<a name='M-circles-NET-CirclesAPIClient-GetUsersAsync-System-String,circles-NET-Enums-Gamemode-'></a>
### GetUsersAsync(name,mode) `method`

##### Summary

Gets a [](#!-APIUser[] 'APIUser[]') matching given parameters asynchronously

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The username to search for |
| mode | [circles.NET.Enums.Gamemode](#T-circles-NET-Enums-Gamemode 'circles.NET.Enums.Gamemode') | The gamemode |

<a name='M-circles-NET-CirclesAPIClient-GetUsersAsync-System-Int32,circles-NET-Enums-Gamemode-'></a>
### GetUsersAsync(name,mode) `method`

##### Summary

Same as [GetUsersAsync](#M-circles-NET-CirclesAPIClient-GetUsersAsync-System-String,circles-NET-Enums-Gamemode- 'circles.NET.CirclesAPIClient.GetUsersAsync(System.String,circles.NET.Enums.Gamemode)') but takes UserID instead of username

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The UserID to search for |
| mode | [circles.NET.Enums.Gamemode](#T-circles-NET-Enums-Gamemode 'circles.NET.Enums.Gamemode') | The gamemode (defaults to [Standard](#F-circles-NET-Enums-Gamemode-Standard 'circles.NET.Enums.Gamemode.Standard')) |

<a name='T-circles-NET-HTTP-CirclesHttpClient'></a>
## CirclesHttpClient `type`

##### Namespace

circles.NET.HTTP

##### Summary

A [HttpClient](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpClient 'System.Net.Http.HttpClient') with methods for deserializing directly API requests content into usable objects

Intended to be only used by [CirclesAPIClient](#T-circles-NET-CirclesAPIClient 'circles.NET.CirclesAPIClient')
