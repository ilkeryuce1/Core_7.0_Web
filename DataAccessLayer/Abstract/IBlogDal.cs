using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal :IGenericDal<Blog>
    {
        //List<Blog> ListAllBlog();
        //void AddBlog(Blog blog);
        //void DeleteBlog(Blog blog);
        //void UpdateBlog (Blog blog);
        //Blog GetBlogId(int id);

        //Bunların yerine  IgernericDal kullandık

        List<Blog> GetListWithCategory();//Bloklara ozel oldukları ıcın burada tanımladık generic yapıya ek olarak metot tanımlama ıcın burayı kullandık 




    }
}
