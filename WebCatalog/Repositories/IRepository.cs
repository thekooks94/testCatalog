using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCatalog.Models;

namespace WebCatalog.Repositories
{
    public interface IRepository<T> where T : EntityBase
    {
        T GetByName(string name);
        void Create(T entity);
        IEnumerable<T> GetAllEntity();
    }
}
