﻿using LanguagePractice.DataAccess.DataContext;
using LanguagePractice.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LanguagePractice.Repositories
{
    public class WordManagementRepository<T> : IWordManagementRepository<T> where T : class
    {
        private readonly WordDatabaseContext _db;
        internal DbSet<T> dbSet;

        public WordManagementRepository(WordDatabaseContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }

        public void Create(T word)
        {
            dbSet.Add(word);
        }

        public void Delete(T word)
        {
            dbSet.Remove(word);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            IQueryable<T> query = dbSet;

            return await query.ToListAsync();
        }

        public async Task<T> GetSingle(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;

            query = query.Where(filter);

            var retrievedWord = await query.FirstOrDefaultAsync();

            if (retrievedWord == null) 
            { 
                throw new NullReferenceException("Word not found.");
            }

            return retrievedWord;
        }

        public void Update(T word)
        {
            dbSet.Update(word);
        }
    }
}
