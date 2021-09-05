﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.DTOs.Finans
{
    public class FinansFirmaDTO
    {
        public int id { get; set; }

        public bool? firmaKurulus { get; set; }

        public int? firmaTurid { get; set; }

        public int? firmaYonid { get; set; }

        public string kodu { get; set; }

        public string adi { get; set; }

        public string vergiNo { get; set; }

        public string vergiDaire { get; set; }

        public int? ilgiliid { get; set; }

        public int? odemePlanid { get; set; }

        public bool? yurtIciFirmaMi { get; set; }

        public int? eIrsaliyeTurid { get; set; }

        public int? eFaturaTurid { get; set; }

        public string eFaturaAdres { get; set; }

        public int? nakliyeTurid { get; set; }

        public int? firmaid { get; set; }

        public int? paraBirimid { get; set; }

        public bool? iptalmi { get; set; }

        public bool? silindimi { get; set; }

        public long? kayitEdenid { get; set; }

        public DateTime? kayitTarih { get; set; }

        public long? degistirenid { get; set; }

        public DateTime? degistirmeTarih { get; set; }
    }
}
