using Data.Model;
using Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class JogoRepository
    {
        public void Create(Jogo model)
        {
            using (var context = new JogoContext())
            {
                context.Jogos.Add(model);
                context.SaveChanges();
            }
        }
        public List<Jogo> Read()
        {
            using (var context = new JogoContext())
            {
                return context.Jogos.ToList();
            }
        }
        public Jogo Read(int id)
        {
            using (var context = new JogoContext())
            {
                return context.Jogos.Find(id);
            }
        }
        public void Update(Jogo model)
        {
            using (var context = new JogoContext())
            {
                context.Entry<Jogo>(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (var context = new JogoContext())
            {
                context.Entry<Jogo>(this.Read(id)).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
