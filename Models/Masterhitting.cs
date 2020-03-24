using System;
using System.Collections.Generic;

namespace baseballapi.Models
{
    public partial class Masterhitting
    {
        public int Hr { get; set; }
        public int Gidp { get; set; }
        public char GameType { get; set; }
        public string Player { get; set; }
        public int Rbi { get; set; }
        public int Tb { get; set; }
        public decimal Slg { get; set; }
        public decimal Avg { get; set; }
        public int Bb { get; set; }
        public DateTime LastDate { get; set; }
        public int Hbp { get; set; }
        public int G { get; set; }
        public int D { get; set; }
        public string PrimaryPosition { get; set; }
        public int So { get; set; }
        public int BSac { get; set; }
        public int Sf { get; set; }
        public int Tpa { get; set; }
        public int H { get; set; }
        public int Cs { get; set; }
        public decimal Obp { get; set; }
        public int T { get; set; }
        public int Ao { get; set; }
        public int Season { get; set; }
        public int R { get; set; }
        public DateTime FirstDate { get; set; }
        public int OrganizationId { get; set; }
        public int Sb { get; set; }
        public int Ci { get; set; }
        public string PlayerId { get; set; }
        public int Ab { get; set; }
        public int Ibb { get; set; }
        public string TeamId { get; set; }
        public int Go { get; set; }
        public int Id { get; set; }
        public decimal? Woba { get; set; }
        public int? S { get; set; }
        public decimal? Ops { get; set; }
    }

    public partial class HittingSeason 
    {
        public int Hr { get; set; }
        public string Player { get; set; }
        public int Rbi { get; set; }
        public int Tb { get; set; }
        public decimal Slg { get; set; }
        public decimal Avg { get; set; }
        public int Bb { get; set; }
        public int Hbp { get; set; }
        public int G { get; set; }
        public int D { get; set; }
        public int So { get; set; }
        public int Tpa { get; set; }
        public int H { get; set; }
        public int Cs { get; set; }
        public decimal Obp { get; set; }
        public int Season { get; set; }
        public int R { get; set; }
        public int Sb { get; set; }
        public string PlayerId { get; set; }
        public int Ab { get; set; }
        public int Ibb { get; set; }
        public string TeamId { get; set; }
        public decimal? Woba { get; set; }
        public int? S { get; set; }
        public decimal? Ops { get; set; }
        public string Name { get; set; }
        public string NameAbbrev { get; set; }
        public string LeagueAbbrev { get; set; }
        public string PrimaryPosition { get; set; }
    }
}
