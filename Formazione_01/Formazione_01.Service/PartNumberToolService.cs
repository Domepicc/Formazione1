using Formazione_01.Domain;
using Formazione_01.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formazione_01.Service
{
    public class PartNumberToolService : IService<PartNumberTool>
    {
        public bool Add(PartNumberTool item)
        {
            PartNumberToolRepository dao = new PartNumberToolRepository();

            return dao.Insert(item);
        }

        public PartNumberTool Create(string partNumber, string toolCode)
        {
            return new PartNumberTool(partNumber, toolCode);
        }

        public List<PartNumberTool> GetAll()
        {
            PartNumberToolRepository dao = new PartNumberToolRepository();

            return dao.ReadAll();
        }

        public PartNumberTool GetById(string id, string id2)
        {
            PartNumberToolRepository dao = new PartNumberToolRepository();

            return dao.ReadById(id, id2);
        }

        public PartNumberTool GetById(string id)
        {
            throw new NotImplementedException();
        }

        public List<PartNumberTool> GetByPartialId(string id)
        {
            throw new NotImplementedException();
        }

        public bool Modify(PartNumberTool item, string id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(string id, string id2)
        {
            PartNumberToolRepository dao = new PartNumberToolRepository();

            return dao.Delete(id, id2);
        }

        public bool Remove(string id)
        {
            throw new NotImplementedException();
        }
    }
}