﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProject.DataAccessLayer.Repositories;
using TraversalCoreProject.EntityLayer.Concrete;

namespace TraversalCoreProject.BusinessLayer.Abstract
{
    public interface ICommentService:IGenericService<Comment>
    {
        List<Comment> TGetDestinationById(int id);

        List<Comment> TGetCommentsWithDestination();
        List<Comment> TGetCommentsWithDestinationAndUser(int id);
    }
}
