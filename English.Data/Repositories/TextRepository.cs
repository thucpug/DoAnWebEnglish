using English.Data.Infrastructure;
using English.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English.Data.Repositories
{
  
    public interface ITextRepository: IRepository<Text>
    {
    }

    public class TextRepository : RepositoryBase<Text>, ITextRepository
    {
        public TextRepository (IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
