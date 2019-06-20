using circles.NET.Converters;
using circles.NET.Enums;
using Newtonsoft.Json;
using System;

namespace circles.NET.Models
{
    /// <summary>
    /// A class representing an osu! beatmap returned by API
    /// </summary>
    public sealed class APIBeatmap : APIModel
    {
        /// <summary>
        /// The ID of the mapset this beatmap belongs to
        /// </summary>
        [JsonProperty(PropertyName = "beatmapset_id")]
        public long MapsetId { get; private set; }

        /// <summary>
        /// The ID of this beatmap
        /// </summary>
        [JsonProperty(PropertyName = "beatmap_id")]
        public long BeatmapId { get; private set; }

        /// <summary>
        /// The <see cref="ApprovedStatus"/> of this beatmap
        /// </summary>
        [JsonProperty(PropertyName = "approved")]
        [JsonConverter(typeof(EnumConverter<ApprovedStatus>))]
        public ApprovedStatus ApprovedStatus { get; private set; }

        /// <summary>
        /// The genre of this beatmap (set)
        /// </summary>
        [JsonProperty(PropertyName = "genre_id")]
        [JsonConverter(typeof(EnumConverter<Genre>))]
        public Genre Genre { get; private set; }

        /// <summary>
        /// The language of this beatmap (set)
        /// </summary>
        [JsonProperty(PropertyName = "language_id")]
        [JsonConverter(typeof(EnumConverter<Language>))]
        public Language Language { get; private set; }

        /// <summary>
        /// The total length (in seconds) of this beatmap
        /// </summary>
        [JsonProperty(PropertyName = "total_length")]
        public int TotalLength { get; private set; }

        /// <summary>
        /// The playable length (in seconds) of this beatmap
        /// </summary>
        [JsonProperty(PropertyName = "hit_length")]
        public int PlaybableLength { get; private set; }

        /// <summary>
        /// The name of this beatmap's difficulty
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Difficulty { get; private set; }

        /// <summary>
        /// The MD5 hash of this beatmap
        /// </summary>
        [JsonProperty(PropertyName = "file_md5")]
        public string MD5 { get; private set; }

        /// <summary>
        /// Circle Size
        /// </summary>
        [JsonProperty(PropertyName = "diff_size")]
        public float CS { get; private set; }

        /// <summary>
        /// Overall Difficulty
        /// </summary>
        [JsonProperty(PropertyName = "diff_overall")]
        public float OD { get; private set; }

        /// <summary>
        /// Approach Rate
        /// </summary>
        [JsonProperty(PropertyName = "diff_approach")]
        public float AR { get; private set; }

        /// <summary>
        /// HP Drain
        /// </summary>
        [JsonProperty(PropertyName = "diff_drain")]
        public float HP { get; private set; }

        /// <summary>
        /// The gamemode of this beatmap
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        [JsonConverter(typeof(EnumConverter<Gamemode>))]
        public Gamemode Gamemode { get; private set; }

        /// <summary>
        /// The date this beatmap was submitted
        /// </summary>
        [JsonProperty(PropertyName = "submit_date")]
        public DateTime? SubmissionDate { get; private set; }

        /// <summary>
        /// The date this beatmap was approved
        /// </summary>
        [JsonProperty(PropertyName = "approved_date")]
        public DateTime? ApprovedDate { get; private set; }

        /// <summary>
        /// The date this beatmap was last updated
        /// </summary>
        [JsonProperty(PropertyName = "last_update")]
        public DateTime LastUpdate { get; private set; }

        /// <summary>
        /// Compositor of the beatmap's music
        /// </summary>
        [JsonProperty(PropertyName = "artist")]
        public string Artist { get; private set; }

        /// <summary>
        /// Title name of the beatmap's music
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; private set; }

        /// <summary>
        /// Creator of the beatmap
        /// </summary>
        [JsonProperty(PropertyName = "creator")]
        public string Creator { get; private set; }

        /// <summary>
        /// The rating for this map
        /// </summary>
        [JsonProperty(PropertyName = "rating")]
        public float Rating { get; private set; }

        /// <summary>
        /// BPM of the beatmap
        /// </summary>
        [JsonProperty(PropertyName = "bpm")]
        public float Bpm { get; private set; }

        /// <summary>
        /// Source of the beatmap's music
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; private set; }

        /// <summary>
        /// Tags of the beatmap
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public string Tags { get; private set; }

        /// <summary>
        /// Number of times this beatmap has been favourited
        /// </summary>
        [JsonProperty(PropertyName = "favourite_count")]
        public int FavouriteCount { get; private set; }

        /// <summary>
        /// Number of times this beamap has been played
        /// </summary>
        [JsonProperty(PropertyName = "playcount")]
        public int Playcount { get; private set; }

        /// <summary>
        /// Number of times people passed this beatmap
        /// </summary>
        [JsonProperty(PropertyName = "passcount")]
        public int Passcount { get; private set; }

        /// <summary>
        /// The max achievable combo on this map
        /// </summary>
        [JsonProperty(PropertyName = "max_combo")]
        public int? MaxCombo { get; private set; }

        /// <summary>
        /// The difficulty star rating of this beatmap
        /// </summary>
        [JsonProperty(PropertyName = "difficultyrating")]
        public float StarRating { get; private set; }

        /// <summary>
        /// The difficulty star rating for raw aim
        /// </summary>
        [JsonProperty(PropertyName = "diff_aim")]
        public float? AimRating { get; private set; }

        /// <summary>
        /// The difficulty star rating for raw speed
        /// </summary>
        [JsonProperty(PropertyName = "diff_speed")]
        public float? SpeedRating { get; private set; }

        /// <summary>
        /// The number of "normal" hitobjects in this beatmap.
        /// </summary>
        [JsonProperty(PropertyName = "count_normal")]
        public int NormalObjectCount { get; private set; }

        /// <summary>
        /// The number of "slider" hitobjects in this beatmap.
        /// </summary>
        [JsonProperty(PropertyName = "count_slider")]
        public int SliderObjectCount { get; private set; }

        /// <summary>
        /// The number of "spinner" hitobjects in this beatmap.
        /// </summary>
        [JsonProperty(PropertyName = "count_spinner")]
        public int SpinnerObjectCount { get; private set; }

        /// <summary>
        /// An bool indicating whether the audio for this beatmap set is unavalaible (DMCA takedown ?)
        /// </summary>
        [JsonProperty(PropertyName = "audio_unavailable")]
        public bool AudioUnavalaible { get; private set; }

        /// <summary>
        /// An bool indicating whether the download for this beatmap (set) is unavalaible (DMCA takedown ?)
        /// </summary>
        [JsonProperty(PropertyName = "download_unavailable")]
        public bool DownloadUnavalaible { get; private set; }
    }
}