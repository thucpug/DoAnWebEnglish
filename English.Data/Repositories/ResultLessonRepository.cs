using English.Data.Infrastructure;
using English.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English.Data.Repositories
{

    public interface IResultLessonRepository : IRepository<ResultLesson>
    {
    }

    public class ResultLessonRepository : RepositoryBase<ResultLesson>, IResultLessonRepository
    {
        public ResultLessonRepository (IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
