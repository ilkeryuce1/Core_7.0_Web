﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repostories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfCategoryRepos : GenericRepos<Category>, ICategoryDal
    //Icateory dal ıcındekı ve genericrepos ıcındekı metotları da alacaktır 
    {
    }
}
