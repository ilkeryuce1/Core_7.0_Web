using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IBlogServices
	{
		void AddCategory(Blog blog);
		void RemoveCategory(Blog blog);
		void UpdateCategory(Blog blog);
		List<Blog> GetAllBlog();
		Blog GetById(int id);
		List<Blog> GetListWithCategory();//EfBlogReposdaki Metpodu burada cagırdık ve Blog managerden implemente ettik gerekli kodları ıcersııne yazdık

		List<Blog> GetBlogListWriter(int id);
	}
}
