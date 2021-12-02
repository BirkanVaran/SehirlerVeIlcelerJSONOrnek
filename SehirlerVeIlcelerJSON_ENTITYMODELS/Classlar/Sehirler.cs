using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SehirlerVeIlcelerJSON_ENTITYMODELS.Classlar
{
    public class Sehirler
    {
        public string SehirAdi { get; set; }
        public string PlakaKodu { get; set; }
        public List<String> Ilceleri { get; set; }

    }
}
