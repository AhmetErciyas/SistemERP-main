namespace ERP.Data.DAO.Base
{
    public abstract class BaseDAO<TIdentity> where TIdentity : struct
    {
        public TIdentity Id { get; set; }
        public bool Aktif { get; set; }
    }
}
