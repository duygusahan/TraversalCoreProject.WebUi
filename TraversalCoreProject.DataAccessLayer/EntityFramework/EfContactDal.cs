﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProject.DataAccessLayer.Abstract;
using TraversalCoreProject.DataAccessLayer.Concrete;
using TraversalCoreProject.DataAccessLayer.Repositories;
using TraversalCoreProject.EntityLayer.Concrete;

namespace TraversalCoreProject.DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public EfContactDal(TraversalContext context) : base(context)
        {
        }
    }
}