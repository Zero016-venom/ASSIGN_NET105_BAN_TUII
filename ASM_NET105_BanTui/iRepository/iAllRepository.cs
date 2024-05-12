using System;
namespace ASM_NET105_BanTui.iRepository
{
	public interface iAllRepository<T> where T : class
	{
        //Test
        public ICollection<T> GetAll();
        public T GetById(dynamic id);
        public bool CreateObj(T obj);
        public bool UpdateObj(T obj);
        public bool DeleteObj(T obj);
    }
}

