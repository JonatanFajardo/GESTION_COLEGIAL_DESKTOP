using Gestion.Colegial.Commons.Extensions;
using System.Threading.Tasks;

namespace Gestion.Colegial.Business.Services
{
    public class HomeService
    {
        public static async Task<Answer> AlumnosList()
        {
            return await AlumnosServices.List();
        }

        public static async Task<Answer> EncargadosList()
        {
            return await EncargadosServices.List();
        }

        public static async Task<Answer> EmpleadosList()
        {
            return await EmpleadosServices.List();
        }

        public static async Task<Answer> EventosList()
        {
            return await EventosServices.List();
        }
    }
}
