using System.Data;

namespace Gestion.Colegial.Business.Interfaces
{
    interface IServices<T>
    {
        DataTable Find(string sear);
        void Add(T entidad);
        void Edit(T entidad);
        void Remove(int delete);
    }
}
