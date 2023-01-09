﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
			throw new NotImplementedException();
		}
		public List<Blog> GetBlogByID(int id)
		{
			return _blogDal.GetListAll(x=>x.BlogID==id);
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
	}
}
