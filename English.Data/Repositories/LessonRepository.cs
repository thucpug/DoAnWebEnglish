using English.Data.Infrastructure;
using English.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English.Data.Repositories
{
   
    public interface ILessonRepository : IRepository<Lesson>
    {
    }

    public class LessonRepository : RepositoryBase<Lesson>, ILessonRepository
    {
        public LessonRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
