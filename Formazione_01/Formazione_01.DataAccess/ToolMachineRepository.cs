using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formazione_01.Domain;

namespace Formazione_01.DataAccess
{
    public class ToolMachineRepository : IRepository<ToolMachine>
    {
        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id, string id2)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ToolMachine item)
        {
            using( MyDBContext mydb = new MyDBContext())
            {
                mydb.ToolMachine.Add(item);
                return mydb.SaveChanges() > 0;  
            }

        }

        public List<ToolMachine> ReadByIdTool(string id)
        {

            using(MyDBContext mydb = new MyDBContext())
            {
                return mydb.ToolMachine.Where(tm => tm.Tool.IdTool.Equals(id)).ToList();
            }
        }

        public List<ToolMachine> ReadAll()
        {
            throw new NotImplementedException();
        }

        public ToolMachine ReadById(string id)
        {
            throw new NotImplementedException();

        }

        public ToolMachine ReadById(string id, string id2)
        {
            throw new NotImplementedException();
        }

        public List<ToolMachine> ReadByPartialId(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ToolMachine item, string key)
        {
            throw new NotImplementedException();
        }
    }
}
