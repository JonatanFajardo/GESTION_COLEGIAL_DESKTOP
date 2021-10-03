//using Gestion.Colegial.Business;
//using Gestion.Colegial.Commons.Clases;
using Gestion.Colegial.UI.FormsBase;
using System;

namespace Gestion.Colegial.UI.Forms
{
    public partial class Docente_Add : Add_Base
    {

        // /*===============================================
        //                 INSTANCIACIAS
        // ================================================*/

        //// private B_Docente objNegocio = new B_Docente();

        // B_Docente objLogica = new B_Docente();
        // //BBL.Clases.Logica Logica = new BBL.Clases.Logica();
        // E_Docente objEntidad = new E_Docente();
        // Docente docente = new Docente();
        // public Docente_Add()
        // {
        //     InitializeComponent();
        //     init();
        // }

        // private void init()
        // {
        //     Docente docente = new Docente();
        //     docente.Send += new Docente.send(ejecuta);
        //     docente.Show();
        // }


        // public void ejecuta(List<string> date)
        // {
        //     txtPrimerN.Text = date[0];
        //     txtSegundoN.Text = date[1];
        //     txtApellidoP.Text = date[2];
        //     txtApellidoM.Text = date[3];
        //     txtNidentida.Text = date[4];
        //     txtNumeroT.Text = date[5];
        //     //dtFecha.Value = Convert.ToDateTime(date[6]);
        // }

        // public Boolean validateForm(string sex)
        // {
        //     Boolean validation = false;
        //     Boolean CamposVacios;

        //     CamposVacios = Logica.validarCamposVacios(this);

        //     if (CamposVacios==true && sex == string.Empty)
        //     {
        //         validation = true;
        //     }
        //     //if ()
        //     //{
        //     //    validation = true;
        //     //}
        //     return validation; 
        // }

        // public Boolean Actualizar = false;
        // public async override void OnClick()
        // {
        //     //DateExamples.llenarFormulario(this);
        //     //condicion del sexo
        //     string sex;
        //     sex = Logica.SexValidation(radioButton1, radioButton2);

        //     Boolean validation = validateForm(sex); 

        //     if (validation == false)
        //     {
        //         try
        //         {
        //             objEntidad.Cat_PrimerNombre = txtPrimerN.Text;
        //             objEntidad.Cat_SegundoNombre = txtSegundoN.Text;
        //             objEntidad.Cat_PrimerApellido = txtApellidoP.Text;
        //             objEntidad.Cat_SegundoApellido = txtApellidoM.Text;
        //             objEntidad.Cat_Dni = txtNidentida.Text;
        //             objEntidad.Cat_CorreoElectronico = txtCorreoE.Text;
        //             objEntidad.Cat_NTelefono = txtNumeroT.Text;
        //             objEntidad.Cat_Fecha_Nacimiento = DateTime.Parse(dtFecha.Value.ToShortDateString());
        //             objEntidad.Cat_Sexo = sex;
        //             objLogica.insert(objEntidad);
        //             docente.buscarTabla("");
        //             Logica.Limpiar(this, pnBackground);
        //             Success.ShowDialog("Se Inserto el registro"); 
        //         }
        //         catch (Exception error)
        //         {
        //             MessageBox.Show("error" + error.Message);
        //         }
        //     }
        //     else
        //     {
        //         Error.ShowDialog("Algunos campos no pueden estar vacios");
        //     }

        // }

        private void lblGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
