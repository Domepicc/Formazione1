using Formazione_01.Domain;
using Formazione_01.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formazione_01.Service
{
    public class TurretService : IService<Turret>
    {
        public bool Add(Turret item)
        {
            TurretsRepository dao = new TurretsRepository();

            return dao.Insert(item);
        }

        public List<Turret> GetAll()
        {
            TurretsRepository dao = new TurretsRepository();

            return dao.ReadAll();
        }

        public Turret GetById(string id)
        {
            TurretsRepository dao = new TurretsRepository();

            return dao.ReadById(id);
        }

        public bool Remove(string id)
        {
            TurretsRepository dao = new TurretsRepository();

            return dao.Delete(id);
        }

        public bool Modify(Turret turret, string id)
        {
            TurretsRepository dao = new TurretsRepository();

            return dao.Update(turret, id); ;
        }

        // Metodo creato per evitare che il presentation tier acceda al data tier
        public Turret Create(string id, string description)
        {
            return new Turret(id, description);
        }

        public Turret GetById(string id, string id2)
        {
            throw new NotImplementedException();
        }

        public bool Remove(string id, string id2)
        {
            throw new NotImplementedException();
        }

        public List<Turret> GetByPartialId(string id)
        {
            throw new NotImplementedException();
        }
    }
}