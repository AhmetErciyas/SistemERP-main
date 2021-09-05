namespace ERP.Application.DTOs.OrganizasyonDTOs
{
    public class DepartmanDTO
    {
        public int id { get; set; }
        public int bolumid { get; set; }
        public string adi { get; set; }
    }
    public class DepartmanEkleDTO
    {
       
        public int? bolumid { get; set; }
        public string adi { get; set; }
    }
    public class UnvanEkleDTO
    {
        public string adi { get; set; }
    }
    public class UnvanDTO
    {
        public int id { get; set; }
        public string adi { get; set; }
        
    }

    public class UnvanGuncelleDTO
    {
        public int id { get; set; }
        public string adi { get; set; }

    }
    public class KademeDTO
    {
        public int id { get; set; }
        public string adi { get; set; }
      
    }
    public class KademeEkleDTO
    {
        public string adi { get; set; }
       
    }
    public class KademeGuncelleDTO
    {
        public int id { get; set; }
        public string adi { get; set; }

    }
}
