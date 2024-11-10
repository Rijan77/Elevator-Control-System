using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_a_desktop_app_started.IService
{
    public interface IRepository<T>
    {
        T GetById(string id);
        IEnumerable<T> GetAll();
        void Update(T entity);
        void Insert(T entity);
        void DeleteById(string id);
        void DeleteAll();
	}

}
