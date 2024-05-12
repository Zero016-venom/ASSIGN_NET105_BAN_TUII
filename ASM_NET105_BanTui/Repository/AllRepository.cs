using System;
using ASM_NET105_BanTui.Infrastructure.DatabaseContext;
using ASM_NET105_BanTui.iRepository;
using Microsoft.EntityFrameworkCore;

namespace ASM_NET105_BanTui.Repository
{
	public class AllRepository<T> : iAllRepository<T> where T : class
	{
        AppDbContext _context;
        DbSet<T> _dbSet;
		public AllRepository()
		{
            _context = new AppDbContext();
		}
        public AllRepository(AppDbContext context, DbSet<T> dbSet)
        {
            _context = context;
            _dbSet = dbSet;
        }

        public bool CreateObj(T obj)
        {
            try
            {
                _dbSet.Add(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                var msg = e.Message;
                return false;
            }
        }

        public bool DeleteObj(T obj)
        {
            try
            {
                _dbSet.Remove(obj);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public ICollection<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(dynamic id)
        {
            return _dbSet.Find(id);
        }

        public bool UpdateObj(T obj)
        {
            try
            {
                _dbSet.Update(obj);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

