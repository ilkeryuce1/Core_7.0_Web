using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        //connectionsStringimizi tanımlamak için bu yapıya ıhtıyac duyduk
        //optionsbuilder parametresını kullanarak usesqls server parametresını cagırdık ardından da baglantımızı yazdık.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-QJ144O6\\SQLEXPRESS; database=CoreBlogDb; integrated security=true;TrustServerCertificate=True");
        }
        //Yukarıdakı sınıfa aıt tabloları burada tanımlamıs olduk 
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }

        //migration şlemi için  context sınıfının bulundugu katmanı secmek gerekır 
        //add-migration migrationismi
        //Hata alma durmunda olası durum paket yuklenmeme veya kodlarda hata olabılır 
        //update-database
        //TrustServerCertificate=True ile ssl hatasını cözdük fakat pek guvenlı olmayan bır yontem 
    }
}
