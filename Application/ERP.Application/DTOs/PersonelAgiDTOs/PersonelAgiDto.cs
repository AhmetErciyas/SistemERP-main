using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.DTOs.PersonelAgiDTOs
{
    public class PersonelAgiDto
    {
        public int personelid { get; set; }
        public bool? esCalisiyorMu { get; set; }
        public bool? esinGeliriVarMi { get; set; }
        public int? AgiKapsamindaCocukSayisi { get; set; }
        public int? digerCocuk { get; set; }
    }
    public class PersonelAgiEkleDto
    {
        
        public bool? esCalisiyorMu { get; set; }
        public bool? esinGeliriVarMi { get; set; }
        public int? AgiKapsamindaCocukSayisi { get; set; }
        public int? digerCocuk { get; set; }
    }
    public class PersonelAgiGuncelleDto
    {
        public int personelid { get; set; }

        public bool? esCalisiyorMu { get; set; }
        public bool? esinGeliriVarMi { get; set; }
        public int? AgiKapsamindaCocukSayisi { get; set; }
        public int? digerCocuk { get; set; }
        //public int? personelid { get; set; }

    }
}
