using BusTicket.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Business
{
    public class BaseBusiness<TEntity> where TEntity:class
    {
        BaseRepository<TEntity> repo = new BaseRepository<TEntity>();

        public void Add(TEntity entity)
        {
            repo.Add(entity);
        }

        public void Update(TEntity entity)
        {
            repo.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            repo.Delete(entity);
        }

        public TEntity BringById(int id)
        {
            return repo.BringById(id);
        }

        public List<TEntity> BringAll()
        {
            return repo.BringAll();
        }
    }
}
