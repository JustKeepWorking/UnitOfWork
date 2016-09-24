using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnitOfWork.Model;

namespace UnitOfWork.DAL
{
    public class CourseRespository : Repository<Course, int>, ICourseRespository<int>
    {
        public CourseRespository(DbContext Context) : base(Context)
        {
        }

        public IEnumerable<Course> GetCoursesWithAuthor(int PageIndex, int PageSize)
        {
            return PlutoContext.Courses
                .Include(c => c.Author)
                .OrderBy(c => c.Name)
                .Skip((PageIndex - 1) * PageSize)
                .Take(PageSize)
                .ToList();
        }

        public IEnumerable<Course> GetTopSellingCourses(int Count)
        {
            return PlutoContext.Courses
                .OrderByDescending(c => c.FullPrice)
                .Take(Count)
                .ToList();
        }

        public PlutoContext PlutoContext { get { return Context as PlutoContext; } }
    }
}
