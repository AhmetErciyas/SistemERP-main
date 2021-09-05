using ERP.Core.PageSortFilter;
using ERP.Data.DAO.Base;
using ERP.Domain.Commands.Base;
using ERP.Domain.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERP.Domain.Helpers
{
    public static class QueryHelper
    {
        /// <summary>
        /// BaseGetirQuery tipinde query yaratır ve mediator aracılığıyla gönderir
        /// </summary>
        /// <typeparam name="TIdentity">Entity'nin Id türü (int, byte, long vs..)</typeparam>
        /// <typeparam name="TEntity">Entity/DAO</typeparam>
        /// <param name="mediator">IMediatorHandler instance</param>
        /// <param name="id">Aranılan Entity'nin Id'si</param>
        /// <returns></returns>
        public static async Task<TEntity> SendGetirQuery<TIdentity, TEntity>(IMediatorHandler mediator, TIdentity id)
        {
            return await mediator.SendQuery<BaseGetirQuery<TIdentity, TEntity>, TEntity>(new BaseGetirQuery<TIdentity, TEntity>() { Identity = id });
        }

        /// <summary>
        /// BaseListeleQuery tipinde query yaratır ve mediator aracılığıyla gönderir
        /// </summary>
        /// <typeparam name="TEntity">Dönecek listenin Entity/DAO türü</typeparam>
        /// <param name="mediator">IMediatorHandler instance</param>
        /// <returns></returns>
        public static async Task<IEnumerable<TEntity>> SendListeleQuery<TEntity>(IMediatorHandler mediator, object data = null)
        {
            return await mediator.SendQuery<BaseListeleQuery<TEntity>, List<TEntity>>(new BaseListeleQuery<TEntity>() { Data = data });
        }

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="mediator"></param>
        /// <param name="basePagedSortFilterDAO"></param>
        /// <returns></returns>
        public static async Task<PagedResult<TEntity>> SendPagedListeleQuery<TEntity>(IMediatorHandler mediator, BasePagedSortFilterSearchDAO basePagedSortFilterDAO)
        {
            return await mediator.SendQuery<BasePagedListeleQuery<TEntity>, PagedResult<TEntity>>(new BasePagedListeleQuery<TEntity>(basePagedSortFilterDAO));
        }
    }
}
