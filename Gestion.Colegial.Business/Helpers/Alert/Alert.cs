using Gestion.Colegial.Commons.Extensions;
using System;
using System.Windows.Forms;

namespace Gestion.Colegial.Business.Helpers.Alert
{
    public partial class Alert : Form
    {
        public Alert() { }

        public Alert(string mensaje)
        {
            InitializeComponent();

        }

        #region Propiedades
        public enmType _alert;

        public enmType alert { get => _alert; set => _alert = value; }
        #endregion Propiedades

        #region Metodos

        public Alert(Answer answer, string titulo)
        {
            InitializeComponent();
            if (answer.Access == true)
            {
                Configure(enmType.Success);
            }
            else
            {
                Configure(enmType.Error);
            }
            lblMensaje.Text = answer.Message;
            if (titulo != "")
            {
                lblTitulo.Text = titulo;

            }

        }

        /// <summary>
        /// Muestra una ventada con el mensaje especificado.
        /// </summary>
        /// <param name="title">Texto que respresentara el titulo</param>
        /// <param name="mensaje">Texto con un detalle de el mensaje</param>
        /// <param name="alert">Tipo de mensaje</param>
        public Alert(enmType alert, string mensaje, string title)
        {
            InitializeComponent();
            Configure(alert);
            lblMensaje.Text = mensaje;
            lblTitulo.Text = title;
        }

        private void AssingValues()
        {

        }

        //private void MessageIfNull(string mensaje)
        //{
        //    string Success = "Rergistro almacenado correctamente.";
        //    string Warnin = "";
        //    string Error = "Error";
        //    string Information = "";

        //    string Mensaje = mensaje;
        //    if (mensaje == "")
        //    {
        //        switch (enmtype)
        //        {
        //            case enmType.Success:
        //            Mensaje = Success;

        //            break;
        //        case enmType.Warnin:
        //           Mensaje = Warnin;

        //            break;
        //        case enmType.Error:
        //           Mensaje = Error;

        //            break;
        //        case enmType.Information:
        //                Mensaje = Information;
        //            break;
        //        }
        //    }
        //    else
        //    {

        //    }
        //}

        /// <summary>
        /// Agrega estilos o acciones al alert segun el tipo recibido
        /// </summary>
        /// <param name="enmType"></param>
        private void Configure(enmType enmType)
        {
            switch (enmType)
            {
                case enmType.Success:
                    this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(115)))), ((int)(((byte)(142)))));
                    this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(115)))), ((int)(((byte)(142)))));

                    break;
                case enmType.Warnin:
                    this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
                    this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));

                    break;
                case enmType.Error:
                    this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(11)))), ((int)(((byte)(0)))));
                    this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(11)))), ((int)(((byte)(0)))));

                    break;
                case enmType.Information:
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="title"></param>
        /// <param name="tipo"></param>
        public static void Show(enmType tipo, string mensaje, string title)
        {
            Alert alert = new Alert(tipo, mensaje, title);
            alert.Show();
        }

        /// <summary>
        /// Metodo que muestra mensaje en funcion del tipo de dato.
        /// </summary>
        /// <param name="tipo"></param>
        public static void Show(enmType tipo)
        {
            AlertEntity alertEntity = new AlertEntity();
            string msjTitle = "";
            string msjBody = "";

            switch (tipo)
            {
                case enmType.Success:
                    msjTitle = "Exito";
                    msjBody = alertEntity.Success;
                    break;
                case enmType.Warnin:
                    msjTitle = "Advertencia";
                    msjBody = alertEntity.Warnin;
                    break;
                case enmType.Error:
                    msjTitle = "Error";
                    msjBody = alertEntity.Error;
                    break;
                case enmType.Information:
                    msjTitle = "Información";
                    msjBody = alertEntity.Information;
                    break;
            }

            Alert alert = new Alert(tipo, msjBody, msjTitle);
            alert.Show();
        }


        ///// <summary>
        ///// Muestra un mensaje con tan solo un objeto como parametro
        ///// </summary>
        ///// <param name="answer">objeto que se obtiene del business</param>
        //public static void Show(Answer answer, string titulo = "")
        //{
        //    Alert alert = new Alert(answer, titulo);
        //    alert.Show();
        //}

        #endregion Metodos


        #region Enums
        public enum enmType
        {
            Success,
            Warnin,
            Error,
            Information
        }

        #endregion Enums


        #region Eventos
        public virtual void Aceptar()
        {
            this.Close();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Aceptar();
        }
        #endregion Eventos

    }

}
