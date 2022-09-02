using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formazione_01.Service
{
    public interface IService<T>
    {
        List<T> GetAll();

        T GetById(string id);

        T GetById(string id, string id2);

        List<T> GetByPartialId(string id);

        bool Remove(string id);

        bool Remove(string id, string id2);

        bool Add(T item);

        bool Modify(T item, string id);

    }
}