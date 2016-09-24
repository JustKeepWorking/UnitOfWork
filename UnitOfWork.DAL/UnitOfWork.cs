using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PlutoContext Context;
        public UnitOfWork(PlutoContext Context)
        {
            this.Context = Context;
            Coursers = new CourseRespository(Context);
            Authors = new AuthorRespository(Context);
        }
        public IAuthorRespository<int> Authors
        {
            get; private set;
        }

        public ICourseRespository<int> Coursers
        {
            get; private set;
        }

        public int Complete()
        {
            return Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
