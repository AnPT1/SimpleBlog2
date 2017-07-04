using MiniBlog2.Entities;
using MiniBlog2.Model;
using System.Collections.Generic;
using System.Linq;

namespace MiniBlog2.Infrastructure.Repositories
{

    public interface IUserRepository : IEntityBaseRepository<User>
    {
        User GetSingleUserByUsernamePassword(string userName, string password);
        User GetSingleUserByUserName(string userName);
    }

    public interface IArticleRepository: IEntityBaseRepository<Article>
    {
        List<ArticelResultModel> GetAllArticle();
        Article GetArticleById(int id);
    }
}
