using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formazione_01.Domain;
using Formazione_01.DataAccess;
using static System.Console;

namespace Formazione_01.Service
{
    public class PartNumberService : IService<PartNumber>
    {
        public bool Add(PartNumber item)
        {
            throw new NotImplementedException();
        }

        public List<PartNumber> GetAll()
        {
            PartNumberRepository dao = new PartNumberRepository();
            return dao.ReadAll();
        }

        public PartNumber GetById(string id)
        {
            throw new NotImplementedException();
        }

        public PartNumber GetById(string id, string id2)
        {
            throw new NotImplementedException();
        }

        public List<PartNumber> GetByPartialId(string id)
        {
            throw new NotImplementedException();
        }

        public bool Modify(PartNumber item, string id)
        {
            throw new NotImplementedException();
        }

        public void PrintAll()
        {
            PartNumberRepository dao = new PartNumberRepository();
            List<PartNumber> partNumber = dao.ReadAll();

            foreach (PartNumber p in partNumber)
            {
                WriteLine($" {p.Code} {p.Description} {p.Npk} {p.ToolFile} {p.RelatedCode}");
                foreach (PartNumberTool s in p.PartNumberTools)
                {
                    WriteLine($"      {s.ToolCode}");
                }

            }

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