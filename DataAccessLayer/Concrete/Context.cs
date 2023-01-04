using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = EntityLayer.Concrete.Type;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=OlaTvDB;Trusted_Connection=true");

            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Server=LAPTOP-7U5PUCF6;Initial Catalog=OlaTvDB;" +
               "Persist Security Info=False;User ID=sa;Password=6161;" +
               "MultipleActiveResultSets=False;Encrypt=False;" +
               "TrustServerCertificate=False;Connection Timeout=30;");

        }

        public DbSet<Background> Backgrounds { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<CastTitle> CastTitles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<CommunicationSetting> CommunicationSettings { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<ContentCastTitle> ContentCastTitles { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<Font> Fonts { get; set; }
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
        public DbSet<Shadow> Shadows { get; set; }
        public DbSet<Style> Styles { get; set; }
        public DbSet<StyleContent> StyleContents { get; set; }
        public DbSet<SubtitleAppearance> SubtitleAppearances { get; set; }
        public DbSet<TextSize> TextSizes { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<TypeContent> TypeContents { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<VideoLanguage> VideoLanguages { get; set; }
        public DbSet<Window> Windows { get; set; }


    }
}
