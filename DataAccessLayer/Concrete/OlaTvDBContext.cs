using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = EntityLayer.Concrete.Type;

namespace DataAccessLayer.Concrete
{
    public class OlaTvDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies().UseSqlServer (@"Server=(localdb)\MSSQLLocalDB;Database=OlaTvDB;Trusted_Connection=true");

            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Server=LAPTOP-7U5PUCF6;Initial Catalog=OlaTvDB;" +
               "Persist Security Info=False;User ID=sa;Password=6161;" +
               "MultipleActiveResultSets=False;Encrypt=False;" +
               "TrustServerCertificate=False;Connection Timeout=30;");

        }

        public DbSet<Cast> Casts { get; set; }
        public DbSet<CastTitle> CastTitles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CommunicationSetting> CommunicationSettings { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<ContentCastTitle> ContentCastTitles { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<GenreContent> GenreContents { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<MaturityRating> MaturityRatings { get; set; }
        public DbSet<Packet> Packets { get; set; }
        public DbSet<PlaybackSetting> PlaybackSettings { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<ProfileCommunicationSetting> ProfileCommunicationSettings { get; set; }
        public DbSet<ProfileContent> ProfileContents { get; set; }
        public DbSet<ProfilePlaybackSetting> ProfilePlaybackSettings { get; set; }
        public DbSet<ProfileVideoRating> ProfileVideoRatings { get; set; }
        public DbSet<ProfileVideoWatching> ProfileVideoWatchings { get; set; }
        public DbSet<Style> Styles { get; set; }
        public DbSet<StyleContent> StyleContents { get; set; }
        public DbSet<TextColor> TextColors { get; set; }
        public DbSet<TextSize> TextSizes { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<TypeContent> TypeContents { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<VideoLanguage> VideoLanguages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region VideoLanguage

            var vlBuilder = modelBuilder.Entity<VideoLanguage>();

            vlBuilder
                .HasOne(vl => vl.Language)
                .WithMany(l => l.VideoLanguages)
                .OnDelete(DeleteBehavior.NoAction);

            vlBuilder
                .HasOne(vl => vl.Video)
                .WithMany(v => v.VideoLanguages)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region ProfileContent

            var pcBuilder = modelBuilder.Entity<ProfileContent>();

            pcBuilder
                .HasOne(pc => pc.Profile)
                .WithMany(p => p.ProfileContents)
                .OnDelete(DeleteBehavior.NoAction);

            pcBuilder
                .HasOne(pc => pc.Content)
                .WithMany(c => c.ProfileContents)
                .OnDelete(DeleteBehavior.NoAction);
            #endregion

            #region ProfileVideoRating

            var pvrBuilder = modelBuilder.Entity<ProfileVideoRating>();

            pvrBuilder
                .HasOne(pvr => pvr.Profile)
                .WithMany(p => p.ProfileVideoRatings)
                .OnDelete(DeleteBehavior.NoAction);

            pvrBuilder
                .HasOne(pvr => pvr.Video)
                .WithMany(v => v.ProfileVideoRatings)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region ProfileVideoWatching

            var pvwBuilder = modelBuilder.Entity<ProfileVideoWatching>();

            pvwBuilder
                .HasOne(pvw => pvw.Profile)
                .WithMany(p => p.ProfileVideoWatchings)
                .OnDelete(DeleteBehavior.NoAction);

            pvwBuilder
                .HasOne(pvw => pvw.Video)
                .WithMany(v => v.ProfileVideoWatchings)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            //Bütün ondelete olanları kaldırıyor.
            //foreach (var relationship in modelBuilder.Model.GetEntityTypes().Where(e => !e.IsOwned()).SelectMany(e => e.GetForeignKeys()))
            //{
            //	relationship.DeleteBehavior = DeleteBehavior.NoAction;
            //}
        }

    }
}
