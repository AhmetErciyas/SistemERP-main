namespace ERP.Data.DAO.Organizasyon
{
    public class DepartmanDAO
    {
        public int id { get; set; }
        public int? bolumid { get; set; }
        public string adi { get; set; }
        public string No { get; set; }
    }

    public class UnvanDAO
    {
        public int id { get; set; }
        public string adi { get; set; }
        
    }

    public class KademeDAO
    {
        public int id { get; set; }
        public string adi { get; set; }
     
    }
}
