using MiniBlog2.Entities;
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MiniBlog2.Model;

namespace MiniBlog2.Infrastructure.Repositories
{
    /// <summary>
    /// Concrete realization of access to Users
    /// </summary>
    public class ArticleRepository : EntityBaseRepository<Article>, IArticleRepository
    {
        private readonly new SimpleBlogContext _context;

        public ArticleRepository(SimpleBlogContext context) : base(context)
        {
            _context = context;
        }

        public List<ArticelResultModel> GetAllArticle()
        {
            var query = (from p in _context.Articles
                         join q in _context.Categorys on p.CategoryId equals q.Id
                         select new ArticelResultModel
                         {
                             ArticleContent = p.ArticleContent,
                             ArticleId = p.Id,
                             ArticleTitle = p.ArticleTitle,
                             Author = "Admin",
                             Category = q.CategoryName,
                             CreateDate = p.CreateDate
                         });
            return query.ToList();
        }

        public Article GetArticleById(int id)
        {
            return (from p in _context.Articles where p.Id == id select p).FirstOrDefault();
        }
    }
}
