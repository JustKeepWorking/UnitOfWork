using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnitOfWork.Model;

namespace UnitOfWork.DAL
{
    public class AuthorRespository : Repository<Author, int>, IAuthorRespository<int>
    {
        public AuthorRespository(PlutoContext Context) : base(Context)
        {
        }
        public Author GetAuthorWithCourse<T>(T Key)
        {
            return PlutoContext.Authors
                .Include(a => a.Courses)
                .SingleOrDefault(a => a.Id.Equals(Key));
        }

        public PlutoContext PlutoContext { get { return Context as PlutoContext; } }
    }
}
