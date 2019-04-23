using English.Data.Infrastructure;
using English.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English.Data.Repositories
{
    public interface ICourseRepository : IRepository<Course>
    {
    }

    public class CourseRepository : RepositoryBase<Course>, ICourseRepository
    {
        public CourseRepository (IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
