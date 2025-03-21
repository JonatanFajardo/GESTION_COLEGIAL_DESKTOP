﻿using System.Data;

namespace Gestion.Colegial.Business.Interfaces
{
    interface IServices<T>
    {
        DataTable Find(string sear);
        void Add(T entity);
        void Edit(T entity);
        void Remove(int delete);
    }
}
