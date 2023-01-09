using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repostories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepos : GenericRepos<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        { 
            using (var c=new Context())
            {
                //hangı entitt dahil edilecekse lambda ile eklenır 
                return c.Blogs.Include(x => x.Category).ToList();
                //Ardından busınnes katmanında bu metotdu cagırmamız gerkır
                //I Blog servivese gectik.
            }
         
        }
    }
}
