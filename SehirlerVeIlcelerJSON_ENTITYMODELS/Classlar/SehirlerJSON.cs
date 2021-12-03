using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SehirlerVeIlcelerJSON_ENTITYMODELS.Classlar
{
    public class SehirlerJSON
    {
        // JSON dosyasındaki key değerleriyle aynı olacak şekilde ayarlandı.
        public string il { get; set; }
        public string plaka { get; set; }
        public List<string> ilceleri { get; set; }
    }
}
