using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // Yorum adında bir class olusturun
    // Yazan kişinin adı, soyadı, yorumun yazılma tarihi tutulsun
    // Göreceli zaman adında bir değişken yazılma tarihine göre
    // "1 dk önce", "Şimdi","1 saat önce" gibi değer döndürsün
    internal class Yorum
    {
        public string adiSoyadi { get; set; }
        public DateTime yorumTarihi { get; set; }
        
        public string göreceliZaman 
        { 
            get 
                {
                TimeSpan sure = DateTime.Now - yorumTarihi;

                if (sure.TotalSeconds < 20)
                    return "Şimdi";

                else if (sure.TotalSeconds < 60)
                    return sure.Seconds + " sn önce";

                else if (sure.TotalMinutes < 60)
                    return sure.TotalMinutes + " dk önce";

                return sure.Days + " gün" + sure.Hours + " saat" + sure.Minutes + " dk önce";
                
                }
        }
        public Yorum()
        {
            yorumTarihi = DateTime.Now;
        }
    }
}
