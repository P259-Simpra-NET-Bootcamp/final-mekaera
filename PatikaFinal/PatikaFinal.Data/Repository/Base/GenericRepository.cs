using PatikaFinal.Data.Context;

namespace PatikaFinal.Data.Repository.Base
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly PatikaDbContext context;

        public GenericRepository(PatikaDbContext context)
        {
            this.context = context;
        }

        public void Delete(T t)
        {
            context.Remove(t);
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            context.Add(t);
        }

        public void Update(T t)
        {
            context.Update(t);
        }
    }
}
