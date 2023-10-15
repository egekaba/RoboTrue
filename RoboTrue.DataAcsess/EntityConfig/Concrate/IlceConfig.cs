using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.EntityConfig.Abstract;

namespace RoboTrue.DataAcsess.EntityConfig.Concrate
{
    public class IlceConfig : BaseConfig<Ilce>
    {
        public override void Configure(EntityTypeBuilder<Ilce> builder)
        {
            base.Configure(builder);
            builder.HasData(new Ilce
            {
                Id = 1,
                IlceAdi = "Aladağ",
                SehirId = 1,
                Sehiri = { },
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });
            builder.HasData(new Ilce
            {
                Id = 2,
                IlceAdi = "Ceyhan",
                SehirId = 1,
                Sehiri = { },
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });
            builder.HasData(new Ilce
            {
                Id = 3,
                IlceAdi = "Çukurova",
                SehirId = 1,
                Sehiri = { },
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });
            builder.HasData(new Ilce
            {
                Id = 4,
                IlceAdi = "Feke",
                SehirId = 1,
                Sehiri = { },
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });
            builder.HasData(new Ilce
            {
                Id = 5,
                IlceAdi = "İmamoğlu",
                SehirId = 1,
                Sehiri = { },
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });
            builder.HasData(new Ilce
            {
                Id = 6,
                IlceAdi = "Karaisalı",
                SehirId = 1,
                Sehiri = { },
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });
            builder.HasData(new Ilce
            {
                Id = 7,
                IlceAdi = "Karataş",
                SehirId = 1,
                Sehiri = { },
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });
            builder.HasData(new Ilce
            {
                Id = 8,
                IlceAdi = "Kozan",
                SehirId = 1,
                Sehiri = { },
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });
            builder.HasData(new Ilce
            {
                Id = 9,
                IlceAdi = "Pozantı",
                SehirId = 1,
                Sehiri = { },
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });
            builder.HasData(new Ilce
            {
                Id = 10,
                IlceAdi = "Saimbeyli",
                SehirId = 1,
                Sehiri = { },
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });
            builder.HasData(new Ilce
            {
                Id = 11,
                IlceAdi = "Sarıçam",
                SehirId = 1,
                Sehiri = { },
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });
            builder.HasData(new Ilce
            {
                Id = 12,
                IlceAdi = "Seyhan",
                SehirId = 1,
                Sehiri = { },
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });
            builder.HasData(new Ilce
            {
                Id = 13,
                IlceAdi = "Tufanbeyli",
                SehirId = 1,
                Sehiri = { },
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });
            builder.HasData(new Ilce
            {
                Id = 14,
                IlceAdi = "Yumurtalık",
                SehirId = 1,
                Sehiri = { },
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });
            builder.HasData(new Ilce
            {
                Id = 15,
                IlceAdi = "Yüreğir",
                SehirId = 1,
                Sehiri = { },
                CreateDate = DateTime.Now,
                OlusturanKullaniciId = 1,
                Kullanici = { }
            });

        }
    }
}
