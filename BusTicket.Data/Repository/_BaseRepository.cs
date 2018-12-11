using BusTicket.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//burda da contexti oluştururken singleton oluşturmak gerekli midir ?
namespace BusTicket.Data.Repository
{
    public class BaseRepository<TEntity> where TEntity:class
    {
        //ekle,güncelle,idyegöregetir,hepsinigetir
        //bu çok doğru değil gibi yahu
        BusTicketContext context = new BusTicketContext();

        public void Add(TEntity entity)
        {
            //entityin neyse örn öğrenci tablosunu bulup ekleme yapar
            //set bizim tablolarımızı kasteder
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            //güncellenicek nesne olduğunu anlatır.Id ye göre çalışır
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
            context.SaveChanges();
        }

        public TEntity BringById(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public List<TEntity> BringAll()
        {
            return context.Set<TEntity>().ToList();
        }
    }
}
