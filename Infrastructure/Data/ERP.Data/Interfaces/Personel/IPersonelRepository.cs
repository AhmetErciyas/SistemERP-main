using ERP.Data.DAO.Personel;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Data.Interfaces
{
    public interface IPersonelRepository : IRepository<personel>
    {
        Task<List<PersonelDAO>> PersonelAra(PersonelAraDAO personelAraDAO);
        Task<PersonelDAO> PersonelGetir(int PersonelId);

    }
}
