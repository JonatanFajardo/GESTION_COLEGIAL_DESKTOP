using System;

namespace Gestion.Colegial.Commons.Extensions
{
    /// <summary>
    /// Objeto que permite la comunicacion con datos entre capas
    /// </summary>
    public class Answer
    {
        /// <summary>
        /// Indica si la solicitud fue o no exitosa.
        /// </summary>
        public Boolean Access { get; set; }

        /// <summary>
        /// Informacion que se le mostrara al usuario.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Resultado de la peticion del business.
        /// </summary>
        public dynamic Data { get; set; }

        /// <summary>
        /// Fecha que se registro el problema.
        /// </summary>
        public DateTime RegistrationDate { get; set; }

        /// <summary>
        /// Descripcion resumida del error ocurrido.
        /// </summary>
        public string ErrorGeneral { get; set; }

        /// <summary>
        /// Informacion de los pasos ocurridos antes de el error.
        /// </summary>
        public string StackTrace { get; set; }

        /// <summary>
        /// Informacion del error interno ocurrido.
        /// </summary>
        public string InnerException { get; set; }

        /// <summary>
        /// Descipcion detallada del error ocurrido.
        /// </summary>
        public string ErrorDetails { get; set; }

        public Answer()
        {

            Access = true;
            Message = "Ocurrio un error al intentar ingresar el registro.";
            RegistrationDate = DateTime.Now;
        }
        public void Incidents(Exception exception)
        {
            Message = exception.Message;
            StackTrace = exception.StackTrace;
            //InnerException = exception.InnerException.Message;
            Access = true;
        }
        //public Answer()
        //{
        //    Access = false;
        //    Message = "Ocurrio un error al intentar ingresar el registro.";
        //    RegistrationDate = DateTime.Now;
        //}

    }




}
