using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formazione_01.Domain;
using Formazione_01.DataAccess;

namespace Formazione_01.Service
{
    public class ToolMachineService : IService<ToolMachine>
    {
        public bool Add(ToolMachine item)
        {
            ToolMachineRepository dao = new ToolMachineRepository();
            return dao.Insert(item);
        }

        public List<ToolMachine> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<ToolMachine> GetByIdTool(string id)
        {

            var dao = new ToolMachineRepository();
            return dao.ReadByIdTool(id);
        }

        public ToolMachine GetById(string id)
        {
            ToolMachineRepository dao = new ToolMachineRepository();
            return dao.ReadById(id);
        }

        public ToolMachine GetById(string id, string id2)
        {
            throw new NotImplementedException();
        }

        public List<ToolMachine> GetByPartialId(string id)
        {
            throw new NotImplementedException();
        }

        public bool Modify(ToolMachine item, string id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(string id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(string id, string id2)
        {
            throw new NotImplementedException();
        }

  
    }
}
