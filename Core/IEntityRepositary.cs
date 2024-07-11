﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IEntityRepositary<T> where T : class, IEntity
    {
        void Add (T entity);
        void Update (T entity);
        void Delete (T entity);
        T Get (Expression<Func<T, bool>> filter=null);
        List<T> GetAll (Expression<Func<T, bool>> filter=null);
    }
}
