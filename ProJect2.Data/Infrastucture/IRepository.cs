﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProJect2.Data.Infrastucture
{
    public interface IRepository<T> where T :class
    {
        //danh dau 1 entity moi
        T Add(T entity);

        // danh dau 1  entity sua doi
        void Update(T entity);

        // danh dau 1 entity xoa
        T Delete(T entity);
        T Delete(int id);

        // Delete multi records
        void DeleteMulti(Expression<Func<T, bool>> where);

        // get an entity by int id
        T GetSingleById(int id);

        T GetSingByCondition(Expression<Func<T, bool>> expression, String[] includes = null);

        IEnumerable<T> GetAll(string[] includes = null);

        IEnumerable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);

        IEnumerable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);

        int Count(Expression<Func<T, bool>> where);

        int CheckContains(Expression<Func<T, bool>> predicate);

    }
}
