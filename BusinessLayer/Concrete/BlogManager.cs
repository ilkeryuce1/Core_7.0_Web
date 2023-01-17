using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogServices

	{
		IBlogDal _blogDal;

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

		public void AddCategory(Blog blog)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetAllBlog()
		{
			return _blogDal.GetListAll();
		}

		public Blog GetById(int id)
		{
			return _blogDal.GetById(id);
		}
		public List<Blog> GetBlogByID(int id)
		{
			return _blogDal.GetListAll(x => x.BlogID == id);
		}

		public List<Blog> GetListWithCategory()
		{
			return _blogDal.GetListWithCategory();//Blog kontrollere tekrar geçiyoruz
		}

		public void RemoveCategory(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void UpdateCategory(Blog blog)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetBlogListWriter(int id)
		{//yazarın yazdıgı son yazıları burada listeledik
			return _blogDal.GetListAll(x=>x.WriterID==id).OrderByDescending(x=>x.BlogID).ToList();
		}
	}
}
