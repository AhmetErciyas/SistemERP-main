using ERP.Data;
using ERP.Data.DAO.Kullanici;
using ERP.Data.Entities;
using ERP.Domain.Core;
using ERP.Domain.RuleEngine;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands
{
//entitye dokunuyor 
    public class BlogCommandHandler : BaseCommandHandler,
        IRequestHandler<PostEkleCommand, Post>,
        IRequestHandler<PostGuncelleCommand, bool>,
        IRequestHandler<PostSilCommand, bool>,
        IRequestHandler<AuthorEkleCommand, Author>,
        IRequestHandler<AuthorGuncelleCommand, bool>,
        IRequestHandler<AuthorSilCommand, bool>,
        IRequestHandler<CommentEkleCommand, Comment>,
        IRequestHandler<CommentGuncelleCommand, bool>,
        IRequestHandler<CommentSilCommand, bool>
    {
        private readonly IPostRepository _postRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly ICommentRepository _commentRepository;
        private readonly ITagRepository _tagRepository;

        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly KullaniciDAO _kullanici;

        public BlogCommandHandler(IUnitOfWork unitOfWork,
                                    IMediatorHandler mediator,
                                    INotificationHandler<DomainNotification> notifications,
                                    IHttpContextAccessor httpContextAccessor,
                                    IPostRepository postRepository,
                                    IAuthorRepository authorRepository,
                                    ICommentRepository commentRepository,
                                    ITagRepository tagRepository) : base(unitOfWork, mediator, notifications)
        {
            _httpContextAccessor = httpContextAccessor;
            _kullanici = _httpContextAccessor.HttpContext.GetKullanici();
            _postRepository = postRepository;
            _authorRepository = authorRepository;
            _commentRepository = commentRepository;
            _tagRepository = tagRepository;
        }
        #region Post
        public async Task<Post> Handle(PostEkleCommand request, CancellationToken cancellationToken)
        {
            var post = request.Post;

            var validationResult = RuleManager.Instance.ValidatePostEkle(_postRepository, _authorRepository, post);
            if (!validationResult.Success)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PostEkleCommand).Name, validationResult.Errors));
                return null;
            }

            await _postRepository.AddAsync(post);

            if (await Commit())
            {
                return post;
            }

            return null;
        }

        public async Task<bool> Handle(PostGuncelleCommand request, CancellationToken cancellationToken)
        {
            var post = request.Post;

            var validationResult = RuleManager.Instance.ValidatePostGuncelle(_postRepository, post);
            if (!validationResult.Success)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PostGuncelleCommand).Name, validationResult.Errors));
                return false;
            }

            await _postRepository.UpdateAsync(post);

            if (await Commit())
            {
                return true;
            }

            return false;
        }

        public async Task<bool> Handle(PostSilCommand request, CancellationToken cancellationToken)
        {
            await _postRepository.DeleteAsync(request.PostId);

            if (await Commit())
            {
                return true;
            }

            return false;
        }
        #endregion

        #region Author
        public async Task<Author> Handle(AuthorEkleCommand request, CancellationToken cancellationToken)
        {
            var Author = request.Author;

            var validationResult = RuleManager.Instance.ValidateAuthorEkle(_authorRepository, Author);
            if (!validationResult.Success)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(AuthorEkleCommand).Name, validationResult.Errors));
                return null;
            }

            await _authorRepository.AddAsync(Author);

            if (await Commit())
            {
                return Author;
            }

            return null;
        }

        public async Task<bool> Handle(AuthorGuncelleCommand request, CancellationToken cancellationToken)
        {
            var Author = request.Author;

            var validationResult = RuleManager.Instance.ValidateAuthorGuncelle(_authorRepository, Author);
            if (!validationResult.Success)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(AuthorGuncelleCommand).Name, validationResult.Errors));
                return false;
            }

            await _authorRepository.UpdateAsync(Author);

            if (await Commit())
            {
                return true;
            }

            return false;
        }

        public async Task<bool> Handle(AuthorSilCommand request, CancellationToken cancellationToken)
        {
            await _authorRepository.DeleteAsync(request.AuthorId);

            if (await Commit())
            {
                return true;
            }

            return false;
        }
        #endregion


        #region Comment
        public async Task<Comment> Handle(CommentEkleCommand request, CancellationToken cancellationToken)
        {
            var Comment = request.Comment;

            var validationResult = RuleManager.Instance.ValidateCommentEkle(_commentRepository, Comment);
            if (!validationResult.Success)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(CommentEkleCommand).Name, validationResult.Errors));
                return null;
            }

            await _commentRepository.AddAsync(Comment);

            if (await Commit())
            {
                return Comment;
            }

            return null;
        }

        public async Task<bool> Handle(CommentGuncelleCommand request, CancellationToken cancellationToken)
        {
            var Comment = request.Comment;

            var validationResult = RuleManager.Instance.ValidateCommentGuncelle(_commentRepository, Comment);
            if (!validationResult.Success)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(CommentGuncelleCommand).Name, validationResult.Errors));
                return false;
            }

            await _commentRepository.UpdateAsync(Comment);

            if (await Commit())
            {
                return true;
            }

            return false;
        }

        public async Task<bool> Handle(CommentSilCommand request, CancellationToken cancellationToken)
        {
            await _commentRepository.DeleteAsync(request.CommentId);

            if (await Commit())
            {
                return true;
            }

            return false;
        }
        #endregion

    }
}
