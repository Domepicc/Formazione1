using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formazione_01.Domain;
using Formazione_01.DataAccess;

namespace Formazione_01.Service
{
    public class MachineService : IService<Machine>
    {
        public bool Add(Machine item)
        {
            var dao = new MachineRepository();
            return dao.Insert(item);
        }

        public List<Machine> GetAll()
        {
            var dao = new MachineRepository();
            return dao.ReadAll();
        }

        public Machine GetById(string id)
        {
            var dao = new MachineRepository();
            return dao.ReadById(id);
        }

        public Machine GetById(string id, string id2)
        {
            throw new NotImplementedException();
        }

        public List<Machine> GetByPartialId(string id)
        {
            throw new NotImplementedException();
        }

        public bool Modify(Machine item, string id)
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

        public List<string> GetMachinesCodeExcepted(string id)
        {
            MachineRepository repo = new MachineRepository();
            return repo.ReadMachinesCodeExcepted(id);
        }

        public List<string> GetAllMachineCode()
        {
            MachineRepository repo = new MachineRepository();
            return repo.ReadAllCodeMachine();
        }
    }
}
