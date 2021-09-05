using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.DTOs.PersonelDepartmanDTOs
{
     public class PersonelDepartmanDTO
    {
       
        public int personelid { get; set; }
        public int departmanid { get; set; }
        public string departmanAdi { get; set; }
        public bool? yoneticiMi { get; set; }
        public bool? vekilMi { get; set; }
    }
    public class PersonelDepartmanEkleDTO
    {
       
        public int personelid { get; set; }
        public int departmanid { get; set; }
        public bool? yoneticiMi { get; set; }
        public bool? vekilMi { get; set; }
    }
    public class PersonelDepartmanGuncelleDTO
    {
        public int id { get; set; }
        public int personelid { get; set; }
        public int departmanid { get; set; }
        public bool? yoneticiMi { get; set; }
        public bool? vekilMi { get; set; }
        

    }
}
