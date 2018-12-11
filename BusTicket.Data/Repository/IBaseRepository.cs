using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Data.Repository
{
    public interface IBaseRepository<TEntity> where TEntity:class
    {
        //ekle,güncelle,sil,idyegöregetir,hepsinigetir ne getirirsem getiriyim yine olacak
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity BringById(int id);
        List<TEntity> BringAll();
    }
}
