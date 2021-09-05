using ERP.Application;
using ERP.Application.DTOs;
using ERP.Core.PageSortFilter;
using ERP.Domain.Core;
using ERP.Domain.Core.Response;
using ERP.WebApi.Validation;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERP.WebApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class PostController : BaseController
    {
        private readonly ISampleService _blogService;

        public PostController(INotificationHandler<DomainNotification> notifications,
           IMediatorHandler mediator,
           ISampleService blogService) : base(notifications, mediator)
        {
            _blogService = blogService;
        }

        #region Post

        [HttpGet("post-getir/{id}")]
        public async Task<ApiResponse<PostDTO>> PostGetir(long id)
        {
            var errors = ValidatorFactory.GetBlogValidator().ValidatePostId(id);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<PostDTO>(errors);

            var model = await _blogService.PostGetir(id);
            return ApiResponse(model);
        }
        
        //[Authorize(Roles = "GetKullaniciList")]
        [HttpGet("post-listele")]
        public async Task<ApiResponse<List<PostDTO>>> PostListele()
        {
            var model = await _blogService.PostListele();
            return ApiResponse(model);
        }

        [HttpPost("post-ara")]
        public async Task<ApiResponse<PagedResult<PostDTO>>> PostAra(PostAraDTO postAraDTO)
        {
            var errors = ValidatorFactory.GetBlogValidator().ValidatePostAra(postAraDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<PagedResult<PostDTO>>(errors);

            var model = await _blogService.PostAra(postAraDTO);
            return ApiResponse(model);
        }

        [HttpPost("post-ekle")]
        public async Task<ApiResponse<PostDTO>> PostEkle(PostDTO postDTO)
        {
            var errors = ValidatorFactory.GetBlogValidator().ValidatePost(postDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<PostDTO>(errors);

            var model = await _blogService.PostEkle(postDTO);
            return ApiResponse(model);
        }

        [HttpPost("post-guncelle")]
        public async Task<ApiResponse<bool>> PostGuncelle(PostDTO postDTO)
        {
            var errors = ValidatorFactory.GetBlogValidator().ValidatePost(postDTO);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<bool>(errors);

            var model = await _blogService.PostGuncelle(postDTO);
            return ApiResponse(model);
        }

        [HttpPost("post-sil/{id}")]
        public async Task<ApiResponse<bool>> PostSil(long id)
        {
            var errors = ValidatorFactory.GetBlogValidator().ValidatePostId(id);
            if (errors.Length != 0)
                return ApiResponseFactory.Warning<bool>(errors);

            var model = await _blogService.PostSil(id);
            return ApiResponse(model);
        }

        #endregion Barkod
    }
}
