using Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace E_Mutfak.Models
{
    public class Repository<T> : RepositoryBase, IDataAccess<T> where T : class
    {
        private DbSet<T> _objectSet;


        public Repository()
        {
            _objectSet = context.Set<T>();
        }


        public int Delete(T obj)
        {
            _objectSet.Remove(obj);
            return Save();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _objectSet.FirstOrDefault(where);
        }

        public int Insert(T obj)
        {
            _objectSet.Add(obj);

            return Save();
        }

        public List<T> List()
        {
            return _objectSet.ToList();
        }

        public int Save()
        {
            return context.SaveChanges();
        }

        public int Update(T obj)
        {
            if (obj is User)
            {
                User o = obj as User;
            }
            return Save();
        }
    }
}