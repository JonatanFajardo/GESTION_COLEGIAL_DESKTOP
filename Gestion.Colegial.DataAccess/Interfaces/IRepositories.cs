using System.Data;

namespace Gestion.Colegial.DataAccess.Interfaces
{
    public interface IRepositories<T>
    {
        //Task<T>  Find(string sear);
        /// <summary>
        /// Permite la busqueda de un registro.
        /// </summary>
        /// <param name="sear"></param>
        /// <returns></returns>
        DataTable List(string sear);
        /// <summary>
        /// Permite Agregar un nuevo registro.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Add(T entity);
        /// <summary>
        /// Permite la modificacion de un registro.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Edit(T entity);
        /// <summary>
        /// Permite la eliminacion de un registro.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Remove(int identifier);
    }
}
