﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.DTOs.PersonelEmeklilikDTOs
{
    public class PersonelEmeklilikDTO
    {

        public int? ozelSigortaTurid { get; set; }
        public int? ozelSigortaTurAdi { get; set; }
        public bool? bireyselEmeklilikVar { get; set; }
        public double? EmeklilikKesintiOran { get; set; }
        public string policeNo { get; set; }
        public double? PTOemeklilik { get; set; }
        public double? PTOhayat { get; set; }
        public double? PTOsaglik { get; set; }
        public double? ITOemeklilik { get; set; }
        public double? ITOhayat { get; set; }
        public double? ITOsaglik { get; set; }
    }
    public class PersonelEmeklilikEkleDTO
    {
       
        public int? ozelSigortaTurid { get; set; }
        public bool? bireyselEmeklilikVar { get; set; }
        public double? EmeklilikKesintiOran { get; set; }
        public string policeNo { get; set; }
        public double? PTOemeklilik { get; set; }
        public double? PTOhayat { get; set; }
        public double? PTOsaglik { get; set; }
        public double? ITOemeklilik { get; set; }
        public double? ITOhayat { get; set; }
        public double? ITOsaglik { get; set; }
    }
    public class PersonelEmeklilikGuncelleDTO
    {
        public int personelid { get; set; }
        public int? ozelSigortaTurid { get; set; }
        public bool? bireyselEmeklilikVar { get; set; }
        public double? EmeklilikKesintiOran { get; set; }
        public string policeNo { get; set; }
        public double? PTOemeklilik { get; set; }
        public double? PTOhayat { get; set; }
        public double? PTOsaglik { get; set; }
        public double? ITOemeklilik { get; set; }
        public double? ITOhayat { get; set; }
        public double? ITOsaglik { get; set; }
        

    }
}
