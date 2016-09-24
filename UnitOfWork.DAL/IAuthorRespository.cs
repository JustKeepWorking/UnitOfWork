using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnitOfWork.Model;

namespace UnitOfWork.DAL
{
    public interface IAuthorRespository<TKey> : IRepository<Author, TKey>
        where TKey : struct
    {
        Author GetAuthorWithCourse<T>(T Key);
    }
}
