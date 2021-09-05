using ERP.Data;
using ERP.Data.DAO.Base;
using MediatR;
using System;

namespace ERP.Domain.Core
{

    public abstract class BaseQuery<TResponse> : IAggregateRoot, IRequest<TResponse>
    {
        public DateTime Timestamp { get; private set; }

        protected BaseQuery()
        {
            Timestamp = DateTime.Now;
        }
    }

    /// <summary>
    /// BaseQuery den türetilmedi çünkü
    /// SendQueryPaged yerine SendQuery kullanılırsa
    /// hata vermeyip basePagedSortFilterDAO = null gelecek
    /// </summary>
    /// <typeparam name="TResponse"></typeparam>
    public abstract class BasePagedQuery<TResponse> : IAggregateRoot, IRequest<TResponse>
    {
        public DateTime Timestamp { get; private set; }

        public BasePagedSortFilterSearchDAO BasePagedSortFilterSearchDAO { get; set; }

        protected BasePagedQuery()
        {
            Timestamp = DateTime.Now;
        }
    }
}
