using ERP.Core.PageSortFilter;
using ERP.Data;
using ERP.Data.DAO.Blog;
using ERP.Data.Entities;
using ERP.Domain.Core;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands.Blog
{
    //sadadece read yapıyor.
    public class BlogQueryHandler : BaseQueryHandler,
        IRequestHandler<PostQuery, Post>,
        IRequestHandler<PostAraQuery, PagedResult<PostDAO>>,
        IRequestHandler<PostListeleQuery, List<Post>>
    {
        private readonly IPostRepository _postRepository;

        public BlogQueryHandler(IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notifications,
            IPostRepository postRepository) : base(mediator, notifications)
        {
            _postRepository = postRepository;
        }

        public async Task<PagedResult<PostDAO>> Handle(PostAraQuery request, CancellationToken cancellationToken)
        {
            return await _postRepository.PostAra(request.PostAraDAO);
        }

        public async Task<List<Post>> Handle(PostListeleQuery request, CancellationToken cancellationToken)
        {
            return await _postRepository.GetAsyncWithIncludes(q => true, q => q.OrderByDescending(q => q.Id),"Author", "Tags", "Comments");
        }

        public async Task<Post> Handle(PostQuery request, CancellationToken cancellationToken)
        {
            return await _postRepository.GetFirstOrDefaultAsyncWithIncludes(q => q.Id == request.Id, q => q.OrderByDescending(q => q.Id), "Author", "Tags", "Comments");
        }
    }
}
