using System;
using System.Data;
using System.Threading.Tasks;

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
        Task<DataTable> List(string sear);

        /// <summary>
        /// Permite Agregar un nuevo registro.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// 

        ///// <summary>
        ///// Busca un registro en base al identificador de este.
        ///// </summary>
        ///// <param name="entity"></param>
        ///// <returns></returns>
        //Task<DataTable> Find(int value);

        /// <summary>
        /// Busca un registro en base a la informacion que este contiene.
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns></returns>
        Task<DataTable> Find(string identifier);
        Task<Boolean> Add(T entity);
        /// <summary>
        /// Permite la modificacion de un registro.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<Boolean> Edit(T entity);
        /// <summary>
        /// Permite la eliminacion de un registro.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<Boolean> Remove(int identifier);
    }
}
