using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.EntitySql;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> List();

        int Insert(T p);
        int Update(T p);
        int Delete(T p);

        T GetByID(int id);

        List<T> List(Expression<Func<T,bool>> filter);

        //İstenilen şarta göre search işlemi gerçekleştirebiliriz.//

        T Find(Expression<Func<T, bool>> where);
    }


}
