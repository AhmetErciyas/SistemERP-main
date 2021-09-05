using ERP.Core.PageSortFilter;

namespace ERP.Application.AutoMapper
{
    public interface IERPMapper
    {
        PagedResult<TDestination> MapToPaged<TDestination, TSource>(PagedResult<TSource> source);

        TDestination Map<TDestination>(object data);
    }
}
