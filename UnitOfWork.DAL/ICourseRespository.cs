using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnitOfWork.Model;

namespace UnitOfWork.DAL
{
    public interface ICourseRespository<TKey> : IRepository<Course, TKey> 
        where TKey : struct
    {
        IEnumerable<Course> GetTopSellingCourses(int Count);
        IEnumerable<Course> GetCoursesWithAuthor(int PageIndex, int PageSize);
    }
}
