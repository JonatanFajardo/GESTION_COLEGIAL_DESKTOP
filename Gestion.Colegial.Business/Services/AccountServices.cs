using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.DataAccess.Repositories.app;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Gestion.Colegial.Business.Services
{
    public class AccountServices
    {
        private static AccountRepository objDato = new AccountRepository();

        public static async Task<Boolean> Autentication(tbUsuarios entity)
        {
            DataTable obj = await objDato.Autentication(entity);
            if (obj != null)
            {
                int objInt = Convert.ToInt32(obj.Rows[0].ItemArray[0]);
                //int objInt = Convert.ToInt32(objRow.ItemArray[0]);
                if (objInt == 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
                //return true;
            }
            else
            {
                return true;
            }
        }

        public static async Task<DataTable> List(tbUsuarios entity)
        {
            var obj = await objDato.List(entity);
            return obj;
        }
    }
}