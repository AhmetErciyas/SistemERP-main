using ERP.Application.AutoMapper;
using ERP.Application.DTOs;
using ERP.Core.PageSortFilter;
using ERP.Data.DAO.Blog;
using ERP.Data.Entities;
using ERP.Domain.Commands;
using ERP.Domain.Commands.Base;
using ERP.Domain.Core;
using ERP.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERP.Application.Services
{
    public class SampleService : BaseService, ISampleService
    {

        public SampleService(IMediatorHandler mediator, IERPMapper mapper) : base(mediator, mapper)
        {
        }

        #region Postservice
        public async Task<PagedResult<PostDTO>> PostAra(PostAraDTO postAraDTO)
        {
            try
            {
                var query = _mapper.Map<PostAraQuery>(postAraDTO);
                var sonuc = await _mediator.SendQuery<PostAraQuery, PagedResult<PostDAO>>(query);
                return _mapper.MapToPaged<PostDTO, PostDAO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PostAraQuery).Name, ex));
            }

            return null;
        }

        public async Task<PostDTO> PostEkle(PostDTO postDTO)
        {
            try
            {
                var command = _mapper.Map<PostEkleCommand>(postDTO);
                var sonuc = await _mediator.SendCommand<PostEkleCommand, Post>(command);
                return _mapper.Map<PostDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PostEkleCommand).Name, ex));
            }

            return null;
        }

        public async Task<PostDTO> PostGetir(long id)
        {
            try
            {
                var sonuc = await _mediator.SendQuery<PostQuery, Post>(new PostQuery() { Id = id });
                return _mapper.Map<PostDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(BaseGetirQuery<int, Post>).Name, ex));
            }

            return null;
        }

        public async Task<bool> PostGuncelle(PostDTO postDTO)
        {
            try
            {
                var command = _mapper.Map<PostGuncelleCommand>(postDTO);
                return await _mediator.SendCommand<PostGuncelleCommand, bool>(command);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PostGuncelleCommand).Name, ex));
            }

            return false;
        }

        public async Task<List<PostDTO>> PostListele()
        {
            try
            {
                var query = new PostListeleQuery();
                var sonuc = await _mediator.SendQuery<PostListeleQuery, List<Post>>(query);
                return _mapper.Map<List<PostDTO>>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PostAraQuery).Name, ex));
            }

            return null;
        }

        public async Task<bool> PostSil(long id)
        {
            try
            {
                var command = new PostSilCommand() { PostId = id };
                return await _mediator.SendCommand<PostSilCommand, bool>(command);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PostSilCommand).Name, ex));
            }

            return false;
        }

        #endregion 
    }
}
