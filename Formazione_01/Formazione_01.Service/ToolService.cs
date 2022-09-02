using Formazione_01.DataAccess;
using Formazione_01.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formazione_01.Service
{
    public class ToolService : IService<Tool>
    {
        public List<Tool> GetAll()
        {
            // Anche qui, questa istanziazione diretta non va bene, ma per il momento la lasciamo così
            // Vedi il commento in Program.cs
            var dao = new ToolsRepository();

            return dao.ReadAll();

           
        }

        public int GetNumberROw ()
        {
            var dao = new ToolsRepository();

            return dao.CountRow();
        }

        public Tool GetById(string id)
        {
            var dao = new ToolsRepository();

            return dao.ReadById(id);
        }

        public bool Modify (Tool item)
        {
            var dao = new ToolsRepository();

            return dao.Update(item);
        }

        public bool Modify(Tool item, string idMachine)
        {
            var dao = new ToolsRepository();

            return dao.Update(item, idMachine);
        }

        public Tool GetById(string id, string id2)
        {
            throw new NotImplementedException();
        }

  
        public List<Tool> GetByPartialId(string id)
        {
            var dao = new ToolsRepository();

            return dao.ReadByPartialId(id);
        }
      

        public bool Remove(string id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(string id, string id2)
        {
            throw new NotImplementedException();
        }

        public bool Add(Tool item)
        {
            throw new NotImplementedException();
        }

    }
}
