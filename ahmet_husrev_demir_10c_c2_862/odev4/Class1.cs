using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev4
{
    class ogrencikayit
    {
        public string tcno;
        public string dogumtarihi;
        public string adsoyad;
        public string no;
        public string cinsiyet;
        
        
        public string DogumTarihi
        {
            get { return dogumtarihi; }
            set { dogumtarihi = value; }
        }

        public string No
        {
            get { return no; }
            set { no = value; }
        }

        public string AdSoyad
        {
            get { return adsoyad; }
            set { adsoyad = value; }
        }

        public string Cinsiyet
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }

        public void TcNoAyarla(string tc)
        {
            tcno = tc;
        }

        public string TcNoGonder()
        {
            return tcno;
        }
    }
}
