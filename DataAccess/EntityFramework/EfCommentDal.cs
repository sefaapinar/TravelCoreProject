﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Repository;
using Entity.Concrete;

namespace DataAccess.EntityFramework
{
    public class EfCommentDal:GenericRepository<Comment>, ICommentDal
    {

    }
}
