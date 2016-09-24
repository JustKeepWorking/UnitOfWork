using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRespository<int> Coursers { get; }
        IAuthorRespository<int> Authors { get; }
        int Complete();
    }
}
