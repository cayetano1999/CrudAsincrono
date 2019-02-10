using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudAsincrono.Repositorio
{
   public interface IReporitorioCrud<Entity> where Entity: class
    {

        bool Add(Entity entity);
        bool Update(Entity entity);
        bool Delete(Entity entity);
        Entity Get(int? Id);
        IEnumerable<Entity> GetAll();
        



    }
}
