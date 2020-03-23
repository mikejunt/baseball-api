using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace baseballapi
{
    public partial class baseballdbContext : DbContext
    {
        public baseballdbContext()
        {
        }

        public baseballdbContext(DbContextOptions<baseballdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Masterhitting> Masterhitting { get; set; }
        public virtual DbSet<Masterpitching> Masterpitching { get; set; }
        public virtual DbSet<SeasonConstants> SeasonConstants { get; set; }
        public virtual DbSet<Teams> Teams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<_2017hitting> _2017hitting { get; set; }
        public virtual DbSet<_2017pitching> _2017pitching { get; set; }
        public virtual DbSet<_2018hitting> _2018hitting { get; set; }
        public virtual DbSet<_2018pitching> _2018pitching { get; set; }
        public virtual DbSet<_2019hitting> _2019hitting { get; set; }
        public virtual DbSet<_2019pitching> _2019pitching { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=ec2-35-168-54-239.compute-1.amazonaws.com;Database=db427sdpmj2765;Username=uovfcnctyilsug;Password=261fecc6bda5fb4aa962008e0cfdac3917af8ddfefbb1c93ffda1c1ddc44e64f;SSL Mode=Require;Trust Server Certificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Masterhitting>(entity =>
            {
                entity.ToTable("masterhitting");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Ab).HasColumnName("ab");

                entity.Property(e => e.Ao).HasColumnName("ao");

                entity.Property(e => e.Avg)
                    .HasColumnName("avg")
                    .HasColumnType("numeric(4,3)");

                entity.Property(e => e.BSac).HasColumnName("b_sac");

                entity.Property(e => e.Bb).HasColumnName("bb");

                entity.Property(e => e.Ci).HasColumnName("ci");

                entity.Property(e => e.Cs).HasColumnName("cs");

                entity.Property(e => e.D).HasColumnName("d");

                entity.Property(e => e.FirstDate)
                    .HasColumnName("first_date")
                    .HasColumnType("date");

                entity.Property(e => e.G).HasColumnName("g");

                entity.Property(e => e.GameType).HasColumnName("game_type");

                entity.Property(e => e.Gidp).HasColumnName("gidp");

                entity.Property(e => e.Go).HasColumnName("go");

                entity.Property(e => e.H).HasColumnName("h");

                entity.Property(e => e.Hbp).HasColumnName("hbp");

                entity.Property(e => e.Hr).HasColumnName("hr");

                entity.Property(e => e.Ibb).HasColumnName("ibb");

                entity.Property(e => e.LastDate)
                    .HasColumnName("last_date")
                    .HasColumnType("date");

                entity.Property(e => e.Obp)
                    .HasColumnName("obp")
                    .HasColumnType("numeric(4,3)");

                entity.Property(e => e.Ops)
                    .HasColumnName("ops")
                    .HasColumnType("numeric(4,3)");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.Player)
                    .IsRequired()
                    .HasColumnName("player")
                    .HasMaxLength(30);

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("player_id")
                    .HasMaxLength(7);

                entity.Property(e => e.PrimaryPosition)
                    .IsRequired()
                    .HasColumnName("primary_position")
                    .HasMaxLength(2);

                entity.Property(e => e.R).HasColumnName("r");

                entity.Property(e => e.Rbi).HasColumnName("rbi");

                entity.Property(e => e.S).HasColumnName("s");

                entity.Property(e => e.Sb).HasColumnName("sb");

                entity.Property(e => e.Season).HasColumnName("season");

                entity.Property(e => e.Sf).HasColumnName("sf");

                entity.Property(e => e.Slg)
                    .HasColumnName("slg")
                    .HasColumnType("numeric(4,3)");

                entity.Property(e => e.So).HasColumnName("so");

                entity.Property(e => e.T).HasColumnName("t");

                entity.Property(e => e.Tb).HasColumnName("tb");

                entity.Property(e => e.TeamId)
                    .IsRequired()
                    .HasColumnName("team_id")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Tpa).HasColumnName("tpa");

                entity.Property(e => e.Woba)
                    .HasColumnName("woba")
                    .HasColumnType("numeric(4,3)");
            });

            modelBuilder.Entity<Masterpitching>(entity =>
            {
                entity.ToTable("masterpitching");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Ab).HasColumnName("ab");

                entity.Property(e => e.Ao).HasColumnName("ao");

                entity.Property(e => e.Bb).HasColumnName("bb");

                entity.Property(e => e.Bk).HasColumnName("bk");

                entity.Property(e => e.Bq).HasColumnName("bq");

                entity.Property(e => e.Bqs).HasColumnName("bqs");

                entity.Property(e => e.Cg).HasColumnName("cg");

                entity.Property(e => e.Ci).HasColumnName("ci");

                entity.Property(e => e.ComboShutout).HasColumnName("combo_shutout");

                entity.Property(e => e.Cs).HasColumnName("cs");

                entity.Property(e => e.D).HasColumnName("d");

                entity.Property(e => e.Er).HasColumnName("er");

                entity.Property(e => e.Era)
                    .HasColumnName("era")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.Fip)
                    .HasColumnName("fip")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.FirstDate)
                    .HasColumnName("first_date")
                    .HasColumnType("date");

                entity.Property(e => e.G).HasColumnName("g");

                entity.Property(e => e.GameType).HasColumnName("game_type");

                entity.Property(e => e.Gf).HasColumnName("gf");

                entity.Property(e => e.Gidp).HasColumnName("gidp");

                entity.Property(e => e.Go).HasColumnName("go");

                entity.Property(e => e.Gs).HasColumnName("gs");

                entity.Property(e => e.H).HasColumnName("h");

                entity.Property(e => e.Hb).HasColumnName("hb");

                entity.Property(e => e.Hld).HasColumnName("hld");

                entity.Property(e => e.Hr).HasColumnName("hr");

                entity.Property(e => e.Ibb).HasColumnName("ibb");

                entity.Property(e => e.Ip)
                    .HasColumnName("ip")
                    .HasColumnType("numeric(4,1)");

                entity.Property(e => e.Ir).HasColumnName("ir");

                entity.Property(e => e.Irs).HasColumnName("irs");

                entity.Property(e => e.L).HasColumnName("l");

                entity.Property(e => e.LastDate)
                    .HasColumnName("last_date")
                    .HasColumnType("date");

                entity.Property(e => e.NoHitter).HasColumnName("no_hitter");

                entity.Property(e => e.Np).HasColumnName("np");

                entity.Property(e => e.OneHitter).HasColumnName("one_hitter");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.Outs).HasColumnName("outs");

                entity.Property(e => e.Pa).HasColumnName("pa");

                entity.Property(e => e.Player)
                    .IsRequired()
                    .HasColumnName("player")
                    .HasMaxLength(30);

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("player_id")
                    .HasMaxLength(7);

                entity.Property(e => e.Qs).HasColumnName("qs");

                entity.Property(e => e.R).HasColumnName("r");

                entity.Property(e => e.Rs).HasColumnName("rs");

                entity.Property(e => e.S).HasColumnName("s");

                entity.Property(e => e.Sac).HasColumnName("sac");

                entity.Property(e => e.Sb).HasColumnName("sb");

                entity.Property(e => e.Season).HasColumnName("season");

                entity.Property(e => e.Sf).HasColumnName("sf");

                entity.Property(e => e.Sho).HasColumnName("sho");

                entity.Property(e => e.So).HasColumnName("so");

                entity.Property(e => e.Sv).HasColumnName("sv");

                entity.Property(e => e.Svo).HasColumnName("svo");

                entity.Property(e => e.T).HasColumnName("t");

                entity.Property(e => e.TeamId)
                    .IsRequired()
                    .HasColumnName("team_id")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.ThreeHitter).HasColumnName("three_hitter");

                entity.Property(e => e.TwoHitter).HasColumnName("two_hitter");

                entity.Property(e => e.W).HasColumnName("w");

                entity.Property(e => e.Wp).HasColumnName("wp");

                entity.Property(e => e.Wpct)
                    .HasColumnName("wpct")
                    .HasColumnType("numeric(4,3)");
            });

            modelBuilder.Entity<SeasonConstants>(entity =>
            {
                entity.ToTable("season constants");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fipconst)
                    .HasColumnName("fipconst")
                    .HasColumnType("numeric");

                entity.Property(e => e.League)
                    .IsRequired()
                    .HasColumnName("league")
                    .HasMaxLength(3);

                entity.Property(e => e.LeagueId)
                    .IsRequired()
                    .HasColumnName("league_id")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Season)
                    .IsRequired()
                    .HasColumnName("season")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.SportId)
                    .IsRequired()
                    .HasColumnName("sport_id")
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Teams>(entity =>
            {
                entity.HasKey(e => e.MlbOrgId)
                    .HasName("teams_pkey");

                entity.ToTable("teams");

                entity.Property(e => e.MlbOrgId)
                    .HasColumnName("mlb_org_id")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.ActiveSw)
                    .HasColumnName("active_sw")
                    .HasMaxLength(1);

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(75);

                entity.Property(e => e.AddressCity)
                    .HasColumnName("address_city")
                    .HasMaxLength(20);

                entity.Property(e => e.AddressCountry)
                    .HasColumnName("address_country")
                    .HasMaxLength(6);

                entity.Property(e => e.AddressIntl)
                    .HasColumnName("address_intl")
                    .HasMaxLength(1);

                entity.Property(e => e.AddressLine1)
                    .HasColumnName("address_line1")
                    .HasMaxLength(40);

                entity.Property(e => e.AddressLine2)
                    .HasColumnName("address_line2")
                    .HasMaxLength(40);

                entity.Property(e => e.AddressLine3)
                    .HasColumnName("address_line3")
                    .HasMaxLength(40);

                entity.Property(e => e.AddressProvince)
                    .HasColumnName("address_province")
                    .HasMaxLength(15);

                entity.Property(e => e.AddressState)
                    .HasColumnName("address_state")
                    .HasMaxLength(2);

                entity.Property(e => e.AddressZip)
                    .HasColumnName("address_zip")
                    .HasMaxLength(12);

                entity.Property(e => e.AllStarSw).HasColumnName("all_star_sw");

                entity.Property(e => e.BaseUrl)
                    .HasColumnName("base_url")
                    .HasMaxLength(35);

                entity.Property(e => e.BisTeamCode)
                    .HasColumnName("bis_team_code")
                    .HasMaxLength(3);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(20);

                entity.Property(e => e.Division)
                    .HasColumnName("division")
                    .HasMaxLength(1);

                entity.Property(e => e.DivisionAbbrev)
                    .HasColumnName("division_abbrev")
                    .HasMaxLength(3);

                entity.Property(e => e.DivisionFull)
                    .HasColumnName("division_full")
                    .HasMaxLength(25);

                entity.Property(e => e.DivisionId)
                    .HasColumnName("division_id")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.FileCode)
                    .HasColumnName("file_code")
                    .HasMaxLength(3);

                entity.Property(e => e.FirstYearOfPlay)
                    .IsRequired()
                    .HasColumnName("first_year_of_play")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.FranchiseCode)
                    .HasColumnName("franchise_code")
                    .HasMaxLength(3);

                entity.Property(e => e.HomeOpener)
                    .HasColumnName("home_opener")
                    .HasMaxLength(25);

                entity.Property(e => e.HomeOpenerTime)
                    .HasColumnName("home_opener_time")
                    .HasMaxLength(15);

                entity.Property(e => e.LastYearOfPlay)
                    .IsRequired()
                    .HasColumnName("last_year_of_play")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.League)
                    .HasColumnName("league")
                    .HasMaxLength(2);

                entity.Property(e => e.LeagueAbbrev)
                    .HasColumnName("league_abbrev")
                    .HasMaxLength(2);

                entity.Property(e => e.LeagueFull)
                    .HasColumnName("league_full")
                    .HasMaxLength(20);

                entity.Property(e => e.LeagueId)
                    .IsRequired()
                    .HasColumnName("league_id")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.MlbOrg)
                    .HasColumnName("mlb_org")
                    .HasMaxLength(21);

                entity.Property(e => e.MlbOrgAbbrev)
                    .HasColumnName("mlb_org_abbrev")
                    .HasMaxLength(3);

                entity.Property(e => e.MlbOrgBrief)
                    .HasColumnName("mlb_org_brief")
                    .HasMaxLength(15);

                entity.Property(e => e.MlbOrgShort)
                    .HasColumnName("mlb_org_short")
                    .HasMaxLength(15);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(15);

                entity.Property(e => e.NameAbbrev)
                    .HasColumnName("name_abbrev")
                    .HasMaxLength(3);

                entity.Property(e => e.NameDisplayBrief)
                    .HasColumnName("name_display_brief")
                    .HasMaxLength(15);

                entity.Property(e => e.NameDisplayFull)
                    .HasColumnName("name_display_full")
                    .HasMaxLength(45);

                entity.Property(e => e.NameDisplayLong)
                    .HasColumnName("name_display_long")
                    .HasMaxLength(25);

                entity.Property(e => e.NameDisplayShort)
                    .HasColumnName("name_display_short")
                    .HasMaxLength(15);

                entity.Property(e => e.NameShort)
                    .HasColumnName("name_short")
                    .HasMaxLength(20);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phone_number")
                    .HasMaxLength(20);

                entity.Property(e => e.Season)
                    .IsRequired()
                    .HasColumnName("season")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.SportCode)
                    .HasColumnName("sport_code")
                    .HasMaxLength(3);

                entity.Property(e => e.SportCodeDisplay)
                    .HasColumnName("sport_code_display")
                    .HasMaxLength(25);

                entity.Property(e => e.SportCodeName)
                    .HasColumnName("sport_code_name")
                    .HasMaxLength(3);

                entity.Property(e => e.SportId)
                    .IsRequired()
                    .HasColumnName("sport_id")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.SpringLeague)
                    .HasColumnName("spring_league")
                    .HasMaxLength(2);

                entity.Property(e => e.SpringLeagueAbbrev)
                    .HasColumnName("spring_league_abbrev")
                    .HasMaxLength(2);

                entity.Property(e => e.SpringLeagueFull)
                    .HasColumnName("spring_league_full")
                    .HasMaxLength(25);

                entity.Property(e => e.SpringLeagueId)
                    .HasColumnName("spring_league_id")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(2);

                entity.Property(e => e.StoreUrl)
                    .HasColumnName("store_url")
                    .HasMaxLength(45);

                entity.Property(e => e.TeamCode)
                    .HasColumnName("team_code")
                    .HasMaxLength(3);

                entity.Property(e => e.TeamId)
                    .IsRequired()
                    .HasColumnName("team_id")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.TimeZone)
                    .HasColumnName("time_zone")
                    .HasMaxLength(3);

                entity.Property(e => e.TimeZoneAlt)
                    .HasColumnName("time_zone_alt")
                    .HasMaxLength(25);

                entity.Property(e => e.TimeZoneGeneric)
                    .HasColumnName("time_zone_generic")
                    .HasMaxLength(3);

                entity.Property(e => e.TimeZoneNum).HasColumnName("time_zone_num");

                entity.Property(e => e.TimeZoneText)
                    .HasColumnName("time_zone_text")
                    .HasMaxLength(3);

                entity.Property(e => e.VenueId)
                    .IsRequired()
                    .HasColumnName("venue_id")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.VenueName)
                    .HasColumnName("venue_name")
                    .HasMaxLength(45);

                entity.Property(e => e.VenueShort)
                    .HasColumnName("venue_short")
                    .HasMaxLength(30);

                entity.Property(e => e.WebsiteUrl)
                    .HasColumnName("website_url")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Username)
                    .HasName("unique username")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Favteam)
                    .IsRequired()
                    .HasColumnName("favteam")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(128);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(16);
            });

            modelBuilder.Entity<_2017hitting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("2017hitting");

                entity.Property(e => e.Ab).HasColumnName("ab");

                entity.Property(e => e.Ao).HasColumnName("ao");

                entity.Property(e => e.Avg)
                    .HasColumnName("avg")
                    .HasColumnType("numeric(4,3)");

                entity.Property(e => e.BSac).HasColumnName("b_sac");

                entity.Property(e => e.Bb).HasColumnName("bb");

                entity.Property(e => e.Ci).HasColumnName("ci");

                entity.Property(e => e.Cs).HasColumnName("cs");

                entity.Property(e => e.D).HasColumnName("d");

                entity.Property(e => e.FirstDate)
                    .HasColumnName("first_date")
                    .HasColumnType("date");

                entity.Property(e => e.G).HasColumnName("g");

                entity.Property(e => e.GameType).HasColumnName("game_type");

                entity.Property(e => e.Gidp).HasColumnName("gidp");

                entity.Property(e => e.Go).HasColumnName("go");

                entity.Property(e => e.H).HasColumnName("h");

                entity.Property(e => e.Hbp).HasColumnName("hbp");

                entity.Property(e => e.Hr).HasColumnName("hr");

                entity.Property(e => e.Ibb).HasColumnName("ibb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd()
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.LastDate)
                    .HasColumnName("last_date")
                    .HasColumnType("date");

                entity.Property(e => e.Obp)
                    .HasColumnName("obp")
                    .HasColumnType("numeric(4,3)");

                entity.Property(e => e.Ops)
                    .HasColumnName("ops")
                    .HasColumnType("numeric(4,3)");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.Player)
                    .IsRequired()
                    .HasColumnName("player")
                    .HasMaxLength(30);

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("player_id")
                    .HasMaxLength(7);

                entity.Property(e => e.PrimaryPosition)
                    .IsRequired()
                    .HasColumnName("primary_position")
                    .HasMaxLength(2);

                entity.Property(e => e.R).HasColumnName("r");

                entity.Property(e => e.Rbi).HasColumnName("rbi");

                entity.Property(e => e.S).HasColumnName("s");

                entity.Property(e => e.Sb).HasColumnName("sb");

                entity.Property(e => e.Season).HasColumnName("season");

                entity.Property(e => e.Sf).HasColumnName("sf");

                entity.Property(e => e.Slg)
                    .HasColumnName("slg")
                    .HasColumnType("numeric(4,3)");

                entity.Property(e => e.So).HasColumnName("so");

                entity.Property(e => e.T).HasColumnName("t");

                entity.Property(e => e.Tb).HasColumnName("tb");

                entity.Property(e => e.TeamId)
                    .IsRequired()
                    .HasColumnName("team_id")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Tpa).HasColumnName("tpa");

                entity.Property(e => e.Woba)
                    .HasColumnName("woba")
                    .HasColumnType("numeric(4,3)");
            });

            modelBuilder.Entity<_2017pitching>(entity =>
            {
                entity.ToTable("2017pitching");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Ab).HasColumnName("ab");

                entity.Property(e => e.Ao).HasColumnName("ao");

                entity.Property(e => e.Bb).HasColumnName("bb");

                entity.Property(e => e.Bk).HasColumnName("bk");

                entity.Property(e => e.Bq).HasColumnName("bq");

                entity.Property(e => e.Bqs).HasColumnName("bqs");

                entity.Property(e => e.Cg).HasColumnName("cg");

                entity.Property(e => e.Ci).HasColumnName("ci");

                entity.Property(e => e.ComboShutout).HasColumnName("combo_shutout");

                entity.Property(e => e.Cs).HasColumnName("cs");

                entity.Property(e => e.D).HasColumnName("d");

                entity.Property(e => e.Er).HasColumnName("er");

                entity.Property(e => e.Era)
                    .HasColumnName("era")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.Fip)
                    .HasColumnName("fip")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.FirstDate)
                    .HasColumnName("first_date")
                    .HasColumnType("date");

                entity.Property(e => e.G).HasColumnName("g");

                entity.Property(e => e.GameType).HasColumnName("game_type");

                entity.Property(e => e.Gf).HasColumnName("gf");

                entity.Property(e => e.Gidp).HasColumnName("gidp");

                entity.Property(e => e.Go).HasColumnName("go");

                entity.Property(e => e.Gs).HasColumnName("gs");

                entity.Property(e => e.H).HasColumnName("h");

                entity.Property(e => e.Hb).HasColumnName("hb");

                entity.Property(e => e.Hld).HasColumnName("hld");

                entity.Property(e => e.Hr).HasColumnName("hr");

                entity.Property(e => e.Ibb).HasColumnName("ibb");

                entity.Property(e => e.Ip)
                    .HasColumnName("ip")
                    .HasColumnType("numeric(4,1)");

                entity.Property(e => e.Ir).HasColumnName("ir");

                entity.Property(e => e.Irs).HasColumnName("irs");

                entity.Property(e => e.L).HasColumnName("l");

                entity.Property(e => e.LastDate)
                    .HasColumnName("last_date")
                    .HasColumnType("date");

                entity.Property(e => e.NoHitter).HasColumnName("no_hitter");

                entity.Property(e => e.Np).HasColumnName("np");

                entity.Property(e => e.OneHitter).HasColumnName("one_hitter");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.Outs).HasColumnName("outs");

                entity.Property(e => e.Pa).HasColumnName("pa");

                entity.Property(e => e.Player)
                    .IsRequired()
                    .HasColumnName("player")
                    .HasMaxLength(30);

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("player_id")
                    .HasMaxLength(7);

                entity.Property(e => e.Qs).HasColumnName("qs");

                entity.Property(e => e.R).HasColumnName("r");

                entity.Property(e => e.Rs).HasColumnName("rs");

                entity.Property(e => e.S).HasColumnName("s");

                entity.Property(e => e.Sac).HasColumnName("sac");

                entity.Property(e => e.Sb).HasColumnName("sb");

                entity.Property(e => e.Season).HasColumnName("season");

                entity.Property(e => e.Sf).HasColumnName("sf");

                entity.Property(e => e.Sho).HasColumnName("sho");

                entity.Property(e => e.So).HasColumnName("so");

                entity.Property(e => e.Sv).HasColumnName("sv");

                entity.Property(e => e.Svo).HasColumnName("svo");

                entity.Property(e => e.T).HasColumnName("t");

                entity.Property(e => e.TeamId)
                    .IsRequired()
                    .HasColumnName("team_id")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.ThreeHitter).HasColumnName("three_hitter");

                entity.Property(e => e.TwoHitter).HasColumnName("two_hitter");

                entity.Property(e => e.W).HasColumnName("w");

                entity.Property(e => e.Wp).HasColumnName("wp");

                entity.Property(e => e.Wpct)
                    .HasColumnName("wpct")
                    .HasColumnType("numeric(4,3)");
            });

            modelBuilder.Entity<_2018hitting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("2018hitting");

                entity.Property(e => e.Ab).HasColumnName("ab");

                entity.Property(e => e.Ao).HasColumnName("ao");

                entity.Property(e => e.Avg)
                    .HasColumnName("avg")
                    .HasColumnType("numeric(4,3)");

                entity.Property(e => e.BSac).HasColumnName("b_sac");

                entity.Property(e => e.Bb).HasColumnName("bb");

                entity.Property(e => e.Ci).HasColumnName("ci");

                entity.Property(e => e.Cs).HasColumnName("cs");

                entity.Property(e => e.D).HasColumnName("d");

                entity.Property(e => e.FirstDate)
                    .HasColumnName("first_date")
                    .HasColumnType("date");

                entity.Property(e => e.G).HasColumnName("g");

                entity.Property(e => e.GameType).HasColumnName("game_type");

                entity.Property(e => e.Gidp).HasColumnName("gidp");

                entity.Property(e => e.Go).HasColumnName("go");

                entity.Property(e => e.H).HasColumnName("h");

                entity.Property(e => e.Hbp).HasColumnName("hbp");

                entity.Property(e => e.Hr).HasColumnName("hr");

                entity.Property(e => e.Ibb).HasColumnName("ibb");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd()
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.LastDate)
                    .HasColumnName("last_date")
                    .HasColumnType("date");

                entity.Property(e => e.Obp)
                    .HasColumnName("obp")
                    .HasColumnType("numeric(4,3)");

                entity.Property(e => e.Ops)
                    .HasColumnName("ops")
                    .HasColumnType("numeric(4,3)");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.Player)
                    .IsRequired()
                    .HasColumnName("player")
                    .HasMaxLength(30);

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("player_id")
                    .HasMaxLength(7);

                entity.Property(e => e.PrimaryPosition)
                    .IsRequired()
                    .HasColumnName("primary_position")
                    .HasMaxLength(2);

                entity.Property(e => e.R).HasColumnName("r");

                entity.Property(e => e.Rbi).HasColumnName("rbi");

                entity.Property(e => e.S).HasColumnName("s");

                entity.Property(e => e.Sb).HasColumnName("sb");

                entity.Property(e => e.Season).HasColumnName("season");

                entity.Property(e => e.Sf).HasColumnName("sf");

                entity.Property(e => e.Slg)
                    .HasColumnName("slg")
                    .HasColumnType("numeric(4,3)");

                entity.Property(e => e.So).HasColumnName("so");

                entity.Property(e => e.T).HasColumnName("t");

                entity.Property(e => e.Tb).HasColumnName("tb");

                entity.Property(e => e.TeamId)
                    .IsRequired()
                    .HasColumnName("team_id")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Tpa).HasColumnName("tpa");

                entity.Property(e => e.Woba)
                    .HasColumnName("woba")
                    .HasColumnType("numeric(4,3)");
            });

            modelBuilder.Entity<_2018pitching>(entity =>
            {
                entity.ToTable("2018pitching");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Ab).HasColumnName("ab");

                entity.Property(e => e.Ao).HasColumnName("ao");

                entity.Property(e => e.Bb).HasColumnName("bb");

                entity.Property(e => e.Bk).HasColumnName("bk");

                entity.Property(e => e.Bq).HasColumnName("bq");

                entity.Property(e => e.Bqs).HasColumnName("bqs");

                entity.Property(e => e.Cg).HasColumnName("cg");

                entity.Property(e => e.Ci).HasColumnName("ci");

                entity.Property(e => e.ComboShutout).HasColumnName("combo_shutout");

                entity.Property(e => e.Cs).HasColumnName("cs");

                entity.Property(e => e.D).HasColumnName("d");

                entity.Property(e => e.Er).HasColumnName("er");

                entity.Property(e => e.Era)
                    .HasColumnName("era")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.Fip)
                    .HasColumnName("fip")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.FirstDate)
                    .HasColumnName("first_date")
                    .HasColumnType("date");

                entity.Property(e => e.G).HasColumnName("g");

                entity.Property(e => e.GameType).HasColumnName("game_type");

                entity.Property(e => e.Gf).HasColumnName("gf");

                entity.Property(e => e.Gidp).HasColumnName("gidp");

                entity.Property(e => e.Go).HasColumnName("go");

                entity.Property(e => e.Gs).HasColumnName("gs");

                entity.Property(e => e.H).HasColumnName("h");

                entity.Property(e => e.Hb).HasColumnName("hb");

                entity.Property(e => e.Hld).HasColumnName("hld");

                entity.Property(e => e.Hr).HasColumnName("hr");

                entity.Property(e => e.Ibb).HasColumnName("ibb");

                entity.Property(e => e.Ip)
                    .HasColumnName("ip")
                    .HasColumnType("numeric(4,1)");

                entity.Property(e => e.Ir).HasColumnName("ir");

                entity.Property(e => e.Irs).HasColumnName("irs");

                entity.Property(e => e.L).HasColumnName("l");

                entity.Property(e => e.LastDate)
                    .HasColumnName("last_date")
                    .HasColumnType("date");

                entity.Property(e => e.NoHitter).HasColumnName("no_hitter");

                entity.Property(e => e.Np).HasColumnName("np");

                entity.Property(e => e.OneHitter).HasColumnName("one_hitter");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.Outs).HasColumnName("outs");

                entity.Property(e => e.Pa).HasColumnName("pa");

                entity.Property(e => e.Player)
                    .IsRequired()
                    .HasColumnName("player")
                    .HasMaxLength(30);

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("player_id")
                    .HasMaxLength(7);

                entity.Property(e => e.Qs).HasColumnName("qs");

                entity.Property(e => e.R).HasColumnName("r");

                entity.Property(e => e.Rs).HasColumnName("rs");

                entity.Property(e => e.S).HasColumnName("s");

                entity.Property(e => e.Sac).HasColumnName("sac");

                entity.Property(e => e.Sb).HasColumnName("sb");

                entity.Property(e => e.Season).HasColumnName("season");

                entity.Property(e => e.Sf).HasColumnName("sf");

                entity.Property(e => e.Sho).HasColumnName("sho");

                entity.Property(e => e.So).HasColumnName("so");

                entity.Property(e => e.Sv).HasColumnName("sv");

                entity.Property(e => e.Svo).HasColumnName("svo");

                entity.Property(e => e.T).HasColumnName("t");

                entity.Property(e => e.TeamId)
                    .IsRequired()
                    .HasColumnName("team_id")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.ThreeHitter).HasColumnName("three_hitter");

                entity.Property(e => e.TwoHitter).HasColumnName("two_hitter");

                entity.Property(e => e.W).HasColumnName("w");

                entity.Property(e => e.Wp).HasColumnName("wp");

                entity.Property(e => e.Wpct)
                    .HasColumnName("wpct")
                    .HasColumnType("numeric(4,3)");
            });

            modelBuilder.Entity<_2019hitting>(entity =>
            {
                entity.ToTable("2019hitting");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Ab).HasColumnName("ab");

                entity.Property(e => e.Ao).HasColumnName("ao");

                entity.Property(e => e.Avg)
                    .HasColumnName("avg")
                    .HasColumnType("numeric(4,3)");

                entity.Property(e => e.BSac).HasColumnName("b_sac");

                entity.Property(e => e.Bb).HasColumnName("bb");

                entity.Property(e => e.Ci).HasColumnName("ci");

                entity.Property(e => e.Cs).HasColumnName("cs");

                entity.Property(e => e.D).HasColumnName("d");

                entity.Property(e => e.FirstDate)
                    .HasColumnName("first_date")
                    .HasColumnType("date");

                entity.Property(e => e.G).HasColumnName("g");

                entity.Property(e => e.GameType).HasColumnName("game_type");

                entity.Property(e => e.Gidp).HasColumnName("gidp");

                entity.Property(e => e.Go).HasColumnName("go");

                entity.Property(e => e.H).HasColumnName("h");

                entity.Property(e => e.Hbp).HasColumnName("hbp");

                entity.Property(e => e.Hr).HasColumnName("hr");

                entity.Property(e => e.Ibb).HasColumnName("ibb");

                entity.Property(e => e.LastDate)
                    .HasColumnName("last_date")
                    .HasColumnType("date");

                entity.Property(e => e.Obp)
                    .HasColumnName("obp")
                    .HasColumnType("numeric(4,3)");

                entity.Property(e => e.Ops)
                    .HasColumnName("ops")
                    .HasColumnType("numeric(4,3)");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.Player)
                    .IsRequired()
                    .HasColumnName("player")
                    .HasMaxLength(30);

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("player_id")
                    .HasMaxLength(7);

                entity.Property(e => e.PrimaryPosition)
                    .IsRequired()
                    .HasColumnName("primary_position")
                    .HasMaxLength(2);

                entity.Property(e => e.R).HasColumnName("r");

                entity.Property(e => e.Rbi).HasColumnName("rbi");

                entity.Property(e => e.S).HasColumnName("s");

                entity.Property(e => e.Sb).HasColumnName("sb");

                entity.Property(e => e.Season).HasColumnName("season");

                entity.Property(e => e.Sf).HasColumnName("sf");

                entity.Property(e => e.Slg)
                    .HasColumnName("slg")
                    .HasColumnType("numeric(4,3)");

                entity.Property(e => e.So).HasColumnName("so");

                entity.Property(e => e.T).HasColumnName("t");

                entity.Property(e => e.Tb).HasColumnName("tb");

                entity.Property(e => e.TeamId)
                    .IsRequired()
                    .HasColumnName("team_id")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Tpa).HasColumnName("tpa");

                entity.Property(e => e.Woba)
                    .HasColumnName("woba")
                    .HasColumnType("numeric(4,3)");
            });

            modelBuilder.Entity<_2019pitching>(entity =>
            {
                entity.ToTable("2019pitching");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Ab).HasColumnName("ab");

                entity.Property(e => e.Ao).HasColumnName("ao");

                entity.Property(e => e.Bb).HasColumnName("bb");

                entity.Property(e => e.Bk).HasColumnName("bk");

                entity.Property(e => e.Bq).HasColumnName("bq");

                entity.Property(e => e.Bqs).HasColumnName("bqs");

                entity.Property(e => e.Cg).HasColumnName("cg");

                entity.Property(e => e.Ci).HasColumnName("ci");

                entity.Property(e => e.ComboShutout).HasColumnName("combo_shutout");

                entity.Property(e => e.Cs).HasColumnName("cs");

                entity.Property(e => e.D).HasColumnName("d");

                entity.Property(e => e.Er).HasColumnName("er");

                entity.Property(e => e.Era)
                    .HasColumnName("era")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.Fip)
                    .HasColumnName("fip")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.FirstDate)
                    .HasColumnName("first_date")
                    .HasColumnType("date");

                entity.Property(e => e.G).HasColumnName("g");

                entity.Property(e => e.GameType).HasColumnName("game_type");

                entity.Property(e => e.Gf).HasColumnName("gf");

                entity.Property(e => e.Gidp).HasColumnName("gidp");

                entity.Property(e => e.Go).HasColumnName("go");

                entity.Property(e => e.Gs).HasColumnName("gs");

                entity.Property(e => e.H).HasColumnName("h");

                entity.Property(e => e.Hb).HasColumnName("hb");

                entity.Property(e => e.Hld).HasColumnName("hld");

                entity.Property(e => e.Hr).HasColumnName("hr");

                entity.Property(e => e.Ibb).HasColumnName("ibb");

                entity.Property(e => e.Ip)
                    .HasColumnName("ip")
                    .HasColumnType("numeric(4,1)");

                entity.Property(e => e.Ir).HasColumnName("ir");

                entity.Property(e => e.Irs).HasColumnName("irs");

                entity.Property(e => e.L).HasColumnName("l");

                entity.Property(e => e.LastDate)
                    .HasColumnName("last_date")
                    .HasColumnType("date");

                entity.Property(e => e.NoHitter).HasColumnName("no_hitter");

                entity.Property(e => e.Np).HasColumnName("np");

                entity.Property(e => e.OneHitter).HasColumnName("one_hitter");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.Outs).HasColumnName("outs");

                entity.Property(e => e.Pa).HasColumnName("pa");

                entity.Property(e => e.Player)
                    .IsRequired()
                    .HasColumnName("player")
                    .HasMaxLength(30);

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasColumnName("player_id")
                    .HasMaxLength(7);

                entity.Property(e => e.Qs).HasColumnName("qs");

                entity.Property(e => e.R).HasColumnName("r");

                entity.Property(e => e.Rs).HasColumnName("rs");

                entity.Property(e => e.S).HasColumnName("s");

                entity.Property(e => e.Sac).HasColumnName("sac");

                entity.Property(e => e.Sb).HasColumnName("sb");

                entity.Property(e => e.Season).HasColumnName("season");

                entity.Property(e => e.Sf).HasColumnName("sf");

                entity.Property(e => e.Sho).HasColumnName("sho");

                entity.Property(e => e.So).HasColumnName("so");

                entity.Property(e => e.Sv).HasColumnName("sv");

                entity.Property(e => e.Svo).HasColumnName("svo");

                entity.Property(e => e.T).HasColumnName("t");

                entity.Property(e => e.TeamId)
                    .IsRequired()
                    .HasColumnName("team_id")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.ThreeHitter).HasColumnName("three_hitter");

                entity.Property(e => e.TwoHitter).HasColumnName("two_hitter");

                entity.Property(e => e.W).HasColumnName("w");

                entity.Property(e => e.Wp).HasColumnName("wp");

                entity.Property(e => e.Wpct)
                    .HasColumnName("wpct")
                    .HasColumnType("numeric(4,3)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
