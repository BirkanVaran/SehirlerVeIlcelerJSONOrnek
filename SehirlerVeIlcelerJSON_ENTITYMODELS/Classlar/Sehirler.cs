using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SehirlerVeIlcelerJSON_ENTITYMODELS.Classlar
{
    public class Sehirler
    {
        // C# Property kurallarına göre Şehirler isimli Class'ı oluşturduk.
        // JSON Class deserialize olunca oradaki dataları Şehirler Class'ından türeteceğimiz nesneye aktaracağız.
        public string SehirAdi { get; set; }
        public byte PlakaKodu { get; set; }
        public List<String> Ilceleri { get; set; }

    }
}
