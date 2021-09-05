using ERP.Core.PageSortFilter;
using ERP.Data;
using ERP.Data.DAO.Base;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands.Base
{
    public class BasePagedListeleQueryHandler<TEntity> : IRequestHandler<BasePagedListeleQuery<TEntity>, PagedResult<TEntity>> where TEntity : class
    {
        private readonly Dictionary<string, string> propertyMappings;

        protected readonly IRepository<TEntity> _repository;

        public BasePagedListeleQueryHandler(IRepository<TEntity> repository)
        {
            propertyMappings = new Dictionary<string, string>();

            _repository = repository;
        }

        private string GetMappedPropertyName(string s)
        {
            if (propertyMappings.ContainsKey(s.ToLowerInvariant()))
                return propertyMappings[s.ToLowerInvariant()];

            return s;
        }

        protected void AddPropertyMapping(string key, string val)
        {
            propertyMappings.Add(key.ToLowerInvariant(), val);
        }

        /// <summary>
        /// Filte property isimlerini mapliyoruz, dinamik filtre yaratılırken kullanılacak.
        /// Ör: BarkodSiparis için: UrunId -> BarkodSiparisKalem.UrunId
        /// </summary>
        /// <param name="filterItems">FilterItems</param>
        protected void MapPropertyNames(BasePagedSortFilterSearchDAO basePagedSortFilterSearchDAO)
        {
            foreach (var item in basePagedSortFilterSearchDAO.FilterItems)
            {
                item.FilterProperty = GetMappedPropertyName(item.FilterProperty);
            }

            foreach (var item in basePagedSortFilterSearchDAO.SortItems)
            {
                item.SortProperty = GetMappedPropertyName(item.SortProperty);
            }
        }

        /// <summary>
        /// Sorguya "Aktif" filtresi halihazırda eklenmemişse, "Aktif" = true filtresini ekler.
        /// </summary>
        /// <param name="request">Sorgu</param>
        protected void AddAktifFilter(BasePagedListeleQuery<TEntity> request)
        {
            if (!request.PagedSortFilterSearchDAO.FilterItems.Any(fi => fi.FilterProperty.ToLowerInvariant() == "AKTIF"))
            {
                request.PagedSortFilterSearchDAO.FilterItems.Add(new FilterItem()
                {
                    FilterProperty = "Aktif",
                    Operator = FilterOperator.EqualTo,
                    Value = true
                });
            }
        }

        public async virtual Task<PagedResult<TEntity>> Handle(BasePagedListeleQuery<TEntity> request, CancellationToken cancellationToken)
        {
            // dinamik olarak her sorguya [Aktif=true] filtresini ekliyoruz
            AddAktifFilter(request);

            return await _repository.GetPagedAsync(request.PagedSortFilterSearchDAO);
        }
    }
}