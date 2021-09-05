using ERP.Application.DTOs;
using ERP.Core.PageSortFilter;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERP.Application
{
    public interface ISampleService : IDisposable
    {
        #region Post
        Task<List<PostDTO>> PostListele();

        Task<PostDTO> PostGetir(long id);

        Task<PagedResult<PostDTO>> PostAra(PostAraDTO postAraDTO);

        Task<PostDTO> PostEkle(PostDTO postDTO);

        Task<bool> PostGuncelle(PostDTO postDTO);

        Task<bool> PostSil(long id);

        #endregion
    }
}
