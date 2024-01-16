﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SatisDetaylarAdo
    {
        public int ID { get; set; }
        public string UrunAdi { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }

        public int StokMiktari { get; set; }
        public string Yonetici { get; set; }
        public DateTime Tarih { get; set; }
        public string BarkodNo { get; set; }
    }
}