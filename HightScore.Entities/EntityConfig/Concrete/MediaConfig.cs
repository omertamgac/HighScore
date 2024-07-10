using HightScore.Entities.EntityConfig.Abstract;
using HightScore.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HightScore.Entities.EntityConfig.Concrete
{
    public class MediaConfig : BaseConfig<Media>
    {
        public override void Configure(EntityTypeBuilder<Media> builder)
        {
            base.Configure(builder);

            builder.Property(i => i.UserName).IsRequired().HasMaxLength(50);
            builder.Property(i => i.Password).IsRequired().HasMaxLength(100);
            builder.Property(i => i.Country).IsRequired().HasMaxLength(100);
            builder.Property(i => i.City).IsRequired().HasMaxLength(100);
            builder.Property(i => i.Email).IsRequired().HasMaxLength(70);
            builder.Property(i => i.phone).IsRequired().HasMaxLength(30);
            builder.Property(i => i.TaxIdNumber).IsRequired();
            builder.Property(i => i.MediaName).IsRequired().HasMaxLength(50);


            builder.HasIndex(i => i.UserName).IsUnique();
            builder.HasIndex(i => i.Email).IsUnique();
            builder.HasIndex(i => i.phone).IsUnique();
            builder.HasIndex(i => i.TaxIdNumber).IsUnique();
            builder.HasIndex(i => i.MediaName).IsUnique();

            builder.HasData(
    new Media
    {
        Id = 1,
        MediaName = "IGN",
        UserName = "ign_user",
        Password = "password123",
        MediaLogo = null,
        TaxIdNumber = "123456789",
        Country = "USA",
        City = "San Francisco",
        Email = "contact@ign.com",
        phone = "123-456-7890",
        Fax = "123-456-7891"
    },
    new Media
    {
        Id = 2,
        MediaName = "GameSpot",
        UserName = "gamespot_user",
        Password = "password456",
        MediaLogo = null,
        TaxIdNumber = "987654321",
        Country = "USA",
        City = "New York",
        Email = "contact@gamespot.com",
        phone = "987-654-3210",
        Fax = "987-654-3211"
    },
    new Media
    {
        Id = 3,
        MediaName = "Polygon",
        UserName = "polygon_user",
        Password = "password789",
        MediaLogo = null,
        TaxIdNumber = "456789123",
        Country = "USA",
        City = "Atlanta",
        Email = "contact@polygon.com",
        phone = "456-789-1230",
        Fax = "456-789-1231"
    },
    new Media
    {
        Id = 4,
        MediaName = "Kotaku",
        UserName = "kotaku_user",
        Password = "password321",
        MediaLogo = null,
        TaxIdNumber = "654321987",
        Country = "USA",
        City = "Los Angeles",
        Email = "contact@kotaku.com",
        phone = "654-321-9870",
        Fax = "654-321-9871"
    },
    new Media
    {
        Id = 5,
        MediaName = "Eurogamer",
        UserName = "eurogamer_user",
        Password = "password654",
        MediaLogo = null,
        TaxIdNumber = "321987654",
        Country = "UK",
        City = "Brighton",
        Email = "contact@eurogamer.net",
        phone = "321-987-6540",
        Fax = "321-987-6541"
    },
    new Media
    {
        Id = 6,
        MediaName = "Game Informer",
        UserName = "gameinformer_user",
        Password = "password987",
        MediaLogo = null,
        TaxIdNumber = "789123456",
        Country = "USA",
        City = "Minneapolis",
        Email = "contact@gameinformer.com",
        phone = "789-123-4560",
        Fax = "789-123-4561"
    },
    new Media
    {
        Id = 7,
        MediaName = "PC Gamer",
        UserName = "pcgamer_user",
        Password = "password111",
        MediaLogo = null,
        TaxIdNumber = "111222333",
        Country = "UK",
        City = "Bath",
        Email = "contact@pcgamer.com",
        phone = "111-222-3330",
        Fax = "111-222-3331"
    },
    new Media
    {
        Id = 8,
        MediaName = "Rock Paper Shotgun",
        UserName = "rps_user",
        Password = "password222",
        MediaLogo = null,
        TaxIdNumber = "222333444",
        Country = "UK",
        City = "London",
        Email = "contact@rockpapershotgun.com",
        phone = "222-333-4440",
        Fax = "222-333-4441"
    },
    new Media
    {
        Id = 9,
        MediaName = "Destructoid",
        UserName = "destructoid_user",
        Password = "password333",
        MediaLogo = null,
        TaxIdNumber = "333444555",
        Country = "USA",
        City = "San Francisco",
        Email = "contact@destructoid.com",
        phone = "333-444-5550",
        Fax = "333-444-5551"
    },
    new Media
    {
        Id = 10,
        MediaName = "Giant Bomb",
        UserName = "giantbomb_user",
        Password = "password444",
        MediaLogo = null,
        TaxIdNumber = "444555666",
        Country = "USA",
        City = "San Francisco",
        Email = "contact@giantbomb.com",
        phone = "444-555-6660",
        Fax = "444-555-6661"
    },
    new Media
    {
        Id = 11,
        MediaName = "The Verge",
        UserName = "theverge_user",
        Password = "password555",
        MediaLogo = null,
        TaxIdNumber = "555666777",
        Country = "USA",
        City = "New York",
        Email = "contact@theverge.com",
        phone = "555-666-7770",
        Fax = "555-666-7771"
    },
    new Media
    {
        Id = 12,
        MediaName = "VentureBeat",
        UserName = "venturebeat_user",
        Password = "password666",
        MediaLogo = null,
        TaxIdNumber = "666777888",
        Country = "USA",
        City = "San Francisco",
        Email = "contact@venturebeat.com",
        phone = "666-777-8880",
        Fax = "666-777-8881"
    },
    new Media
    {
        Id = 13,
        MediaName = "TechCrunch",
        UserName = "techcrunch_user",
        Password = "password777",
        MediaLogo = null,
        TaxIdNumber = "777888999",
        Country = "USA",
        City = "San Francisco",
        Email = "contact@techcrunch.com",
        phone = "777-888-9990",
        Fax = "777-888-9991"
    },
    new Media
    {
        Id = 14,
        MediaName = "Wired",
        UserName = "wired_user",
        Password = "password888",
        MediaLogo = null,
        TaxIdNumber = "888999000",
        Country = "USA",
        City = "New York",
        Email = "contact@wired.com",
        phone = "888-999-0000",
        Fax = "888-999-0001"
    },
    new Media
    {
        Id = 15,
        MediaName = "Mashable",
        UserName = "mashable_user",
        Password = "password999",
        MediaLogo = null,
        TaxIdNumber = "999000111",
        Country = "USA",
        City = "New York",
        Email = "contact@mashable.com",
        phone = "999-000-1110",
        Fax = "999-000-1111"
    },
    new Media
    {
        Id = 16,
        MediaName = "CNET",
        UserName = "cnet_user",
        Password = "password000",
        MediaLogo = null,
        TaxIdNumber = "000111222",
        Country = "USA",
        City = "San Francisco",
        Email = "contact@cnet.com",
        phone = "000-111-2220",
        Fax = "000-111-2221"
    },
    new Media
    {
        Id = 17,
        MediaName = "Ars Technica",
        UserName = "arstechnica_user",
        Password = "passwordaaa",
        MediaLogo = null,
        TaxIdNumber = "aaa111bbb",
        Country = "USA",
        City = "New York",
        Email = "contact@arstechnica.com",
        phone = "aaa-111-bbb0",
        Fax = "aaa-111-bbb1"
    },
    new Media
    {
        Id = 18,
        MediaName = "Gizmodo",
        UserName = "gizmodo_user",
        Password = "passwordbbb",
        MediaLogo = null,
        TaxIdNumber = "bbb222ccc",
        Country = "USA",
        City = "New York",
        Email = "contact@gizmodo.com",
        phone = "bbb-222-ccc0",
        Fax = "bbb-222-ccc1"
    },
    new Media
    {
        Id = 19,
        MediaName = "Digital Trends",
        UserName = "digitaltrends_user",
        Password = "passwordccc",
        MediaLogo = null,
        TaxIdNumber = "ccc333ddd",
        Country = "USA",
        City = "Portland",
        Email = "contact@digitaltrends.com",
        phone = "ccc-333-ddd0",
        Fax = "ccc-333-ddd1"
    },
    new Media
    {
        Id = 20,
        MediaName = "TechRadar",
        UserName = "techradar_user",
        Password = "passwordddd",
        MediaLogo = null,
        TaxIdNumber = "ddd444eee",
        Country = "UK",
        City = "Bath",
        Email = "contact@techradar.com",
        phone = "ddd-444-eee0",
        Fax = "ddd-444-eee1"
    },


    new Media
    {
        Id = 21,
        MediaName = "Level",
        UserName = "level_user",
        Password = "level_password",
        MediaLogo = null,
        TaxIdNumber = "TR1234567890",
        Country = "Türkiye",
        City = "İstanbul",
        Email = "contact@level.com.tr",
        phone = "+90-212-123-4567",
        Fax = "+90-212-123-4568"
    },
    new Media
    {
        Id = 22,
        MediaName = "Oyungezer",
        UserName = "oyungezer_user",
        Password = "oyungezer_password",
        MediaLogo = null,
        TaxIdNumber = "TR0987654321",
        Country = "Türkiye",
        City = "Ankara",
        Email = "contact@oyungezer.com.tr",
        phone = "+90-312-987-6543",
        Fax = "+90-312-987-6544"
    },
    new Media
    {
        Id = 23,
        MediaName = "Merlin'in Kazanı",
        UserName = "merlin_user",
        Password = "merlin_password",
        MediaLogo = null,
        TaxIdNumber = "TR5678901234",
        Country = "Türkiye",
        City = "İstanbul",
        Email = "contact@merlininkazani.com",
        phone = "+90-212-567-8901",
        Fax = "+90-212-567-8902"
    },
    new Media
    {
        Id = 24,
        MediaName = "Turuncu Levye",
        UserName = "turunculevye_user",
        Password = "turunculevye_password",
        MediaLogo = null,
        TaxIdNumber = "TR3456789012",
        Country = "Türkiye",
        City = "İzmir",
        Email = "contact@turunculevye.com",
        phone = "+90-232-345-6789",
        Fax = "+90-232-345-6790"
    },
    new Media
    {
        Id = 25,
        MediaName = "Multiplayer",
        UserName = "multiplayer_user",
        Password = "multiplayer_password",
        MediaLogo = null,
        TaxIdNumber = "TR4567890123",
        Country = "Türkiye",
        City = "Bursa",
        Email = "contact@multiplayer.com.tr",
        phone = "+90-224-456-7890",
        Fax = "+90-224-456-7891"
    },
    new Media
    {
        Id = 26,
        MediaName = "Tamindir",
        UserName = "tamindir_user",
        Password = "tamindir_password",
        MediaLogo = null,
        TaxIdNumber = "TR6789012345",
        Country = "Türkiye",
        City = "Antalya",
        Email = "contact@tamindir.com",
        phone = "+90-242-678-9012",
        Fax = "+90-242-678-9013"
    },
    new Media
    {
        Id = 27,
        MediaName = "Donanım Haber",
        UserName = "donanimhaber_user",
        Password = "donanimhaber_password",
        MediaLogo = null,
        TaxIdNumber = "TR7890123456",
        Country = "Türkiye",
        City = "İstanbul",
        Email = "contact@donanimhaber.com",
        phone = "+90-212-789-0123",
        Fax = "+90-212-789-0124"
    },
    new Media
    {
        Id = 28,
        MediaName = "Technopat",
        UserName = "technopat_user",
        Password = "technopat_password",
        MediaLogo = null,
        TaxIdNumber = "TR8901234567",
        Country = "Türkiye",
        City = "İstanbul",
        Email = "contact@technopat.net",
        phone = "+90-212-890-1234",
        Fax = "+90-212-890-1235"
    },
    new Media
    {
        Id = 29,
        MediaName = "ShiftDelete.Net",
        UserName = "shiftdelete_user",
        Password = "shiftdelete_password",
        MediaLogo = null,
        TaxIdNumber = "TR9012345678",
        Country = "Türkiye",
        City = "İstanbul",
        Email = "contact@shiftdelete.net",
        phone = "+90-212-901-2345",
        Fax = "+90-212-901-2346"
    },
    new Media
    {
        Id = 30,
        MediaName = "Webtekno",
        UserName = "webtekno_user",
        Password = "webtekno_password",
        MediaLogo = null,
        TaxIdNumber = "TR0123456789",
        Country = "Türkiye",
        City = "İstanbul",
        Email = "contact@webtekno.com",
        phone = "+90-212-012-3456",
        Fax = "+90-212-012-3457"
    }







);


        }
    }
}
