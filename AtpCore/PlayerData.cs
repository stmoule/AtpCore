using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AtpCore
{

    public partial class PlayerData
    {
        [JsonProperty("Content")]
        public Content Content { get; set; }

        [JsonProperty("Data")]
        public Data Data { get; set; }
    }

    public partial class Content
    {
        [JsonProperty("Advert")]
        public object Advert { get; set; }

        [JsonProperty("RankingsContentModel")]
        public RankingsContentModel RankingsContentModel { get; set; }
    }

    public partial class RankingsContentModel
    {
        [JsonProperty("RankingsSponsorUri")]
        public string RankingsSponsorUri { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("Rankings")]
        public Rankings Rankings { get; set; }
    }

    public partial class Rankings
    {
        [JsonProperty("RankDate")]
        public DateTimeOffset RankDate { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Players")]
        public PlayerJson[] Players { get; set; }
    }

    public partial class PlayerJson
    {
        [JsonProperty("Type")]
        public object Type { get; set; }

        [JsonProperty("PlayerId")]
        public string PlayerId { get; set; }

        [JsonProperty("LastName")]
        public string LastName { get; set; }

        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("NatlId")]
        public string NatlId { get; set; }

        [JsonProperty("CountryName")]
        public string CountryName { get; set; }

        [JsonProperty("AgeAtRankDate")]
        public long AgeAtRankDate { get; set; }

        [JsonProperty("Rank")]
        public long Rank { get; set; }

        [JsonProperty("Points")]
        public long Points { get; set; }

        [JsonProperty("IsTie")]
        public bool IsTie { get; set; }

        [JsonProperty("NbrEventsPlayed")]
        public long NbrEventsPlayed { get; set; }

        [JsonProperty("PrevRank")]
        public long PrevRank { get; set; }

        [JsonProperty("PrevPoints")]
        public long PrevPoints { get; set; }

        [JsonProperty("PointsDropping")]
        public long PointsDropping { get; set; }

        [JsonProperty("NextBestPoints")]
        public long NextBestPoints { get; set; }

        [JsonProperty("LastWeekPosMove")]
        public long LastWeekPosMove { get; set; }

        [JsonProperty("PlayerGladiatorImageCmsUrl")]
        public string PlayerGladiatorImageCmsUrl { get; set; }

        [JsonProperty("PlayerHeadshotImageCmsUrl")]
        public string PlayerHeadshotImageCmsUrl { get; set; }
    }
}
