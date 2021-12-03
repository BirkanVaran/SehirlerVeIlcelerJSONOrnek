using Newtonsoft.Json.Linq;
using SehirlerVeIlcelerJSON_ENTITYMODELS.Classlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SehirlerVeIlcelerJSON_BLL
{
    public class SehirlerVeIlcelerServis
    {
        private string JSONString = string.Empty;
        SehirlerServis SehirServisi = new SehirlerServis();
        public SehirlerVeIlcelerServis()
        {
            VeriKaynaginaBaglan();
        }
        public void VeriKaynaginaBaglan()
        {
            using (WebClient istemci = new WebClient()) 
            {
                byte[] data = istemci.DownloadData(@"C:\Users\103SABAH_BİRKAN\Source\Repos\SehirlerVeIlcelerJSONOrnek\belediyelerfull.json");
                JSONString = Encoding.UTF8.GetString(data);
            }
        }
        public List<SehirVeIlceBilgileri> BilgileriGetir()
        {
            List<SehirVeIlceBilgileri> liste = new List<SehirVeIlceBilgileri>();

            JObject j = JObject.Parse(JSONString);
            List<string> Sehirlerim = SehirServisi.SehirleriGetir().Select(x=>x.SehirAdi).ToList();
            Sehirlerim = Sehirlerim.Select(x => DilIslemleri.TurkceKarakterleriIngilizceyeCevir(x.ToLower())).ToList();

            foreach (string item in Sehirlerim)
            {
                // Her bir şehir için, bilgileri belediyelerfull.JSON dosyasından çekeceğiz.
                var data = j.SelectToken(item).SelectToken("il");
                SehirVeIlceBilgileri detayliBilgi = new SehirVeIlceBilgileri();
                detayliBilgi.PlakaKodu = Convert.ToByte(data["plaka"].ToObject<string>());
                detayliBilgi.Tel = data["belediye-tel"].ToObject<string>();
                detayliBilgi.Faks = data["belediye-faks"].ToObject<string>();
                detayliBilgi.Isım = data["belediye-ismi"].ToObject<string>();
                detayliBilgi.Mail = data["belediye-mail"] == null ? "" : data["belediye-ismi"].ToObject<string>();
                detayliBilgi.Web = data["belediye-web"] == null ? "" : data["belediye-web"].ToObject<string>();
                detayliBilgi.Nufus = data["nufus"].ToObject<string>();
                detayliBilgi.AlanKodu = data["alankodu"] == null ? "" : data["alankodu"].ToObject<string>();
                detayliBilgi.Bolge = data["bolge"].ToObject<string>();
                detayliBilgi.Bilgi = data["bilgi"].ToString();

                liste.Add(detayliBilgi);
            }



            return liste;
        }
    }
}
