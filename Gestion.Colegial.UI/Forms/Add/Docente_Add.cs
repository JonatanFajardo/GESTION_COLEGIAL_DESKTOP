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
        //             objentity.Cat_PrimerNombre = txtPrimerN.Text;
        //             objentity.Cat_SegundoNombre = txtSegundoN.Text;
        //             objentity.Cat_PrimerApellido = txtApellidoP.Text;
        //             objentity.Cat_SegundoApellido = txtApellidoM.Text;
        //             objentity.Cat_Dni = txtNidentida.Text;
        //             objentity.Cat_CorreoElectronico = txtCorreoE.Text;
        //             objentity.Cat_NTelefono = txtNumeroT.Text;
        //             objentity.Cat_Fecha_Nacimiento = DateTime.Parse(dtFecha.Value.ToShortDateString());
        //             objentity.Cat_Sexo = sex;
        //             objLogica.insert(objentity);
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
