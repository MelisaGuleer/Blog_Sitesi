using DataAccsessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager
    {
        Repository<Blog> repoblog = new Repository<Blog>();

        public List<Blog> GetAll()
        {
            return repoblog.List();
        }

        public object GetBlogByAuthor(int blogauthorid)
        {
            return repoblog.List();
        }

        public List<Blog> GetBlogByID(int id)
        {
            return repoblog.List(x => x.BlogID == id);   // İlgili sınıfa ait parametre göndermemiz gerekiyor. Bu parametre de BlogID... //
        }
        public List<Blog> GetBlogByCategory(int id)
        {
            return repoblog.List(x => x.CategoryID == id);
        }
    }
}
