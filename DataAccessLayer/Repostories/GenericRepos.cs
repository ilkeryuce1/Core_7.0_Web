using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repostories
{
	public class GenericRepos<T> : IGenericDal<T> where T : class
	{
		Context c = new Context();
		public void Delete(T t)
		{
			c.Remove(t);
			c.SaveChanges();

		}

		public List<T> GetListAll()
		{
			return c.Set<T>().ToList();
		}

		public T GetById(int id)
		{
			return c.Set<T>().Find(id);    //Direk listeledik
		}

		public void Insert(T t)
		{
			c.Add(t);
			c.SaveChanges();

		}

		public List<T> GetListAll(Expression<Func<T, bool>> filter)
		{
			return c.Set<T>().Where(filter).ToList();//Filtreleme işlemini erceklestirip listeleyecek
		}

		public void Update(T t)
		{
			c.Update(t);
			c.SaveChanges();

		}

	
	}
}
