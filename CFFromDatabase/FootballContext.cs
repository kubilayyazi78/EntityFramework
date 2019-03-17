namespace CFFromDatabase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FootballContext : DbContext
    {
        public FootballContext()
            : base("name=FootballContext")
        {
        }

        public virtual DbSet<PlayerAddress> PlayerAddresses { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Sponsor> Sponsors { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .HasOptional(e => e.PlayerAddress)
                .WithRequired(e => e.Player);

            modelBuilder.Entity<Sponsor>()
                .HasMany(e => e.Teams)
                .WithMany(e => e.Sponsors)
                .Map(m => m.ToTable("SponsorTeams"));

            modelBuilder.Entity<Team>()
                .HasMany(e => e.Players)
                .WithOptional(e => e.Team)
                .HasForeignKey(e => e.Team_Id);
        }
    }
}
