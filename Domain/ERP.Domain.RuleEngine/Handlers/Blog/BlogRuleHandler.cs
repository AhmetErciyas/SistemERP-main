using ERP.Data;
using ERP.Data.Entities;
using ERP.Data.Interfaces;
using NRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.RuleEngine.Handlers.Blog
{
    public class BlogRuleHandler : IBlogRuleHandler
    {
        private readonly ISessionFactory sessionFactory;

        public BlogRuleHandler(ISessionFactory sessionFactory)
        {
            this.sessionFactory = sessionFactory;
        }

        #region Post

        public IRuleValidationResult ValidatePostEkle(IPostRepository postRepository, IAuthorRepository authorRepository, Post post)
        {
            var session = sessionFactory.CreateSession(s => s.Agenda.AddFilter(new BaseListFilter("PostEkle")));
            session.Insert(postRepository);
            session.Insert(authorRepository);
            session.Insert(post);
            session.Fire();

            var exceptions = new List<Exception>();
            exceptions.AddRange(session.Query<Exception>());

            return new RuleValidationResult(exceptions.Count == 0, exceptions.Select(e => e.Message).ToArray());
        }

        public IRuleValidationResult ValidatePostGuncelle(IPostRepository postRepository, Post post)
        {
            var session = sessionFactory.CreateSession(s => s.Agenda.AddFilter(new BaseListFilter("PostGuncelle")));
            session.Insert(postRepository);
            session.Insert(post);
            session.Fire();

            var exceptions = new List<Exception>();
            exceptions.AddRange(session.Query<Exception>());

            return new RuleValidationResult(exceptions.Count == 0, exceptions.Select(e => e.Message).ToArray());
        }

        public IRuleValidationResult ValidatePostSil(IPostRepository postRepository, Post post)
        {
            var session = sessionFactory.CreateSession(s => s.Agenda.AddFilter(new BaseListFilter("PostSil")));
            session.Insert(postRepository);
            session.Insert(post);
            session.Fire();

            var exceptions = new List<Exception>();
            exceptions.AddRange(session.Query<Exception>());

            return new RuleValidationResult(exceptions.Count == 0, exceptions.Select(e => e.Message).ToArray());
        }

        #endregion

        #region Author

        public IRuleValidationResult ValidateAuthorEkle(IAuthorRepository AuthorRepository, Author Author)
        {
            var session = sessionFactory.CreateSession(s => s.Agenda.AddFilter(new BaseListFilter("AuthorEkle")));
            session.Insert(AuthorRepository);
            session.Insert(Author);
            session.Fire();

            var exceptions = new List<Exception>();
            exceptions.AddRange(session.Query<Exception>());

            return new RuleValidationResult(exceptions.Count == 0, exceptions.Select(e => e.Message).ToArray());
        }

        public IRuleValidationResult ValidateAuthorGuncelle(IAuthorRepository AuthorRepository, Author Author)
        {
            var session = sessionFactory.CreateSession(s => s.Agenda.AddFilter(new BaseListFilter("AuthorGuncelle")));
            session.Insert(AuthorRepository);
            session.Insert(Author);
            session.Fire();

            var exceptions = new List<Exception>();
            exceptions.AddRange(session.Query<Exception>());

            return new RuleValidationResult(exceptions.Count == 0, exceptions.Select(e => e.Message).ToArray());
        }

        public IRuleValidationResult ValidateAuthorSil(IAuthorRepository AuthorRepository, Author Author)
        {
            var session = sessionFactory.CreateSession(s => s.Agenda.AddFilter(new BaseListFilter("AuthorSil")));
            session.Insert(AuthorRepository);
            session.Insert(Author);
            session.Fire();

            var exceptions = new List<Exception>();
            exceptions.AddRange(session.Query<Exception>());

            return new RuleValidationResult(exceptions.Count == 0, exceptions.Select(e => e.Message).ToArray());
        }

        #endregion

        #region Comment

        public IRuleValidationResult ValidateCommentEkle(ICommentRepository CommentRepository, Comment Comment)
        {
            var session = sessionFactory.CreateSession(s => s.Agenda.AddFilter(new BaseListFilter("CommentEkle")));
            session.Insert(CommentRepository);
            session.Insert(Comment);
            session.Fire();

            var exceptions = new List<Exception>();
            exceptions.AddRange(session.Query<Exception>());

            return new RuleValidationResult(exceptions.Count == 0, exceptions.Select(e => e.Message).ToArray());
        }

        public IRuleValidationResult ValidateCommentGuncelle(ICommentRepository CommentRepository, Comment Comment)
        {
            var session = sessionFactory.CreateSession(s => s.Agenda.AddFilter(new BaseListFilter("CommentGuncelle")));
            session.Insert(CommentRepository);
            session.Insert(Comment);
            session.Fire();

            var exceptions = new List<Exception>();
            exceptions.AddRange(session.Query<Exception>());

            return new RuleValidationResult(exceptions.Count == 0, exceptions.Select(e => e.Message).ToArray());
        }

        public IRuleValidationResult ValidateCommentSil(ICommentRepository CommentRepository, Comment Comment)
        {
            var session = sessionFactory.CreateSession(s => s.Agenda.AddFilter(new BaseListFilter("CommentSil")));
            session.Insert(CommentRepository);
            session.Insert(Comment);
            session.Fire();

            var exceptions = new List<Exception>();
            exceptions.AddRange(session.Query<Exception>());

            return new RuleValidationResult(exceptions.Count == 0, exceptions.Select(e => e.Message).ToArray());
        }

        #endregion
    }
}
