using AutoMapper;
using ERP.Core.PageSortFilter;
using System;
using System.Collections.Generic;

namespace ERP.Application.AutoMapper
{
    public class ERPMapper : IERPMapper, IDisposable
    {
        private readonly IMapper _mapper;

        public ERPMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public PagedResult<TDestination> MapToPaged<TDestination, TSource>(PagedResult<TSource> source)
        {
            return new PagedResult<TDestination>(_mapper.Map<List<TDestination>>(source.ResultSet),
                source.TotalCount, source.CurrentPage, source.PageSize);
        }

        public TDestination Map<TDestination>(object data)
        {
            return _mapper.Map<TDestination>(data);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
