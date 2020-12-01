using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtpCore
{
    public partial class PlayerBiography
    {
        public ContentBio Content { get; set; }
        public PlayerBiosData Data { get; set; }
    }

    public partial class ContentBio
    {
        public object Advert { get; set; }
        public PlayerProfileDetails PlayerProfileDetails { get; set; }
    }

    public partial class PlayerProfileDetails
    {
        public string PlayerGladiatorUrl { get; set; }
        public string PlayerHeadshotUrl { get; set; }
        public bool HasGladiator { get; set; }
    }

    public partial class PlayerBiosData
    {
        public string PlayerId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public long HeroRank { get; set; }
        public bool DblSpecialist { get; set; }
        public string NatlId { get; set; }
        public string BioPersonal { get; set; }
        public string BioYearToDate { get; set; }
        public string BioCareerHighlights { get; set; }
        public string Type { get; set; }
    }
}
