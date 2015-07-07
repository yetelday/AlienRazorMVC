using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bo;

namespace AlienRazorDal
{
    class ArticleDao : IRepository<Article>
    {
        public void Insert(Article obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Article obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Article obj)
        {
            throw new NotImplementedException();
        }

        public ICollection<Article> GetAll()
        {
            throw new NotImplementedException();
        }

        public Article GetById(object id)
        {
            throw new NotImplementedException();
        }
    }
}
