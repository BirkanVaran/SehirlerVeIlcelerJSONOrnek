﻿using Newtonsoft.Json;
using SehirlerVeIlcelerJSON_ENTITYMODELS.Classlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SehirlerVeIlcelerJSON_BLL
{
    public class SehirlerServis
    {
        private string JSONString = string.Empty;

        public SehirlerServis()
        {
            VeriKaynaginaBaglan();
        }
        private void VeriKaynaginaBaglan()
        {
            using (WebClient istemci = new WebClient())
            {
                byte[] data = istemci.DownloadData(@"C:\Users\103SABAH_BİRKAN\Source\Repos\SehirlerVeIlcelerJSONOrnek\belediyeler.json");
                /* JSON dosyasındaki türkçe karakterler çevrilitken bozulma yaşanabiliyor.
                 * Encoding UTF8 kullanırsak bütün dillere göre çözümleme sunar. */
                JSONString = Encoding.UTF8.GetString(data);
            }

        }
        public List<Sehirler> SehirleriGetir()
        {
            return JsonConvert.DeserializeObject<List<Sehirler>>(JSONString);
        }


    }
}
