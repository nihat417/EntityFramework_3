using EntityFramework_3.Contexts;
using EntityFramework_3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_3.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        public LibraryDbContext libraryDbContext;
        public DbSet<TEntity> dbSet;

        public Repository(LibraryDbContext libraryDb)
        {
            libraryDbContext = libraryDb;
            dbSet = libraryDb.Set<TEntity>();
        }

        public void Add(TEntity entity)
            => dbSet.Add(entity);

        public void Remove(TEntity entity)
            => dbSet.Remove(entity);

        public void Update(TEntity entity)
            => dbSet.Update(entity);

        public TEntity? GetById(int id)
            => dbSet.Find(id); // for Primary Key
    }
}
