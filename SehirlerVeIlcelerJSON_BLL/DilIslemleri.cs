using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SehirlerVeIlcelerJSON_BLL
{
    public static class DilIslemleri
    {
        public static string TurkceKarakterleriIngilizceyeCevir(string deger)
        {
            return deger
             .Replace("ş", "s")
             .Replace("Ş", "S")
             .Replace("ç", "c")
             .Replace("Ç", "C")
             .Replace("ğ", "g")
             .Replace("Ğ", "G")
             .Replace("ü", "u")
             .Replace("Ü", "U")
             .Replace("ö", "o")
             .Replace("Ö", "O")
             .Replace("ı", "i")
             .Replace("İ", "I");
        }
    }
}
