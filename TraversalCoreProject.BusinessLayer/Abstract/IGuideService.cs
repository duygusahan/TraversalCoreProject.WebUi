﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProject.EntityLayer.Concrete;

namespace TraversalCoreProject.BusinessLayer.Abstract
{
    public interface IGuideService:IGenericService<Guide>
    {
        void TChangeStatusToTrue(int id);
        void TChangeStatusToFalse(int id);
    }
}
