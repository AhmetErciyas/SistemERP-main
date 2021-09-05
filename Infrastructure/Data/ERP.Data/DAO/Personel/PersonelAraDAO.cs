using ERP.Data.DAO.Base;

namespace ERP.Data.DAO.Personel
{
    public class PersonelAraDAO : BasePagedDAO
    {
        public int? PersonelId { get; set; }
        public string SigortaNo { get; set; }
        public string SicilNo { get; set; }
        public int? KademeId { get; set; }
        public int? UnvanId { get; set; }
        //public short? DurumId { get; set; }
        //public int? KisiId { get; set; }
    }
}
