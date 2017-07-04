using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using MiniBlog2.Infrastructure;
using MiniBlog2.Entities;
using MiniBlog2.Infrastructure.Repositories;
using MiniBlog2.Model;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MiniBlog2.Controllers
{
    [Route("api/[controller]")]
    public class ArticleController : BaseController
    {
        private readonly SimpleBlogContext _context;
        private readonly IArticleRepository _articleRepository;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="context"></param>
        /// <param name="articleRepository"></param>
        public ArticleController(SimpleBlogContext context, IArticleRepository articleRepository, IUserRepository userRepository) : base(userRepository)
        {
            _context = context;
            _articleRepository = articleRepository;
        }

        /// <summary>
        /// Get all articles
        /// </summary>
        /// <returns></returns>
        [Route("get-all-article")]
        [HttpGet]
        public List<ArticelResultModel> GetAllArtices()
        {
            return _articleRepository.GetAllArticle();
        }

        /// <summary>
        /// create new Article
        /// </summary>
        /// <returns></returns>
        [Route("get-all-article")]
        [HttpPatch]
        public IActionResult CreateNewArticle([FromBody] Article newArticleData)
        {
            GenericResult<string> result = null;
            try
            {
                newArticleData.CategoryId = 1;
                newArticleData.CreateDate = DateTime.Now;
                _articleRepository.Add(newArticleData);
                result = new GenericResult<string> { Succeeded = true, Message = "Create article successfully!" };
            }
            catch (Exception ex)
            {
                result = new GenericResult<string> { Succeeded = false, Message = "An unexpected error occurred" };
            }
            return new ObjectResult(result);
        }
    }

    public class GenericResult<T>
    {
        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }
    }
}
